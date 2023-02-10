
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SICIT.API.DAL
{
    public enum ExecuteType
    {
        ExecuteReader,
        ExecuteNonQuery,
        ExecuteScalar
    }
    public class SqlHelperFactory : IDisposable
    {
        private bool disposed = false;
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);


        public List<T> ExecuteList<T>(string procedure, IDictionary<string, object> parameters) where T : class, new()
        {
            List<T> lstEntity = null;
            using (SqlConnection _conn = new SqlHelperConnection().connection())
            {
                try
                {
                    using (SqlCommand Command = new SqlCommand(procedure, _conn))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            Command.Parameters.Clear();
                            foreach (KeyValuePair<string, object> kvp in parameters)
                            {
                                Command.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value != null ? kvp.Value : DBNull.Value));
                            }
                        }
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            lstEntity = reader.Select(r => DelegadoAccion<T>(r)).ToList();
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    //Logger?.LogError("Error en sp " + procedure + " se produjo el siguiente error: " + ex.Message);
                    throw new ArgumentException(ex.Message, ex);
                }
                finally
                {
                    if (_conn.State == ConnectionState.Open)
                    {
                        //Logger?.LogInformation("Cerrando conexión en modo sincrono ExecuteList");
                        _conn.Close();
                    }
                }

                return lstEntity;
            }

        }






        public object ExecuteProcedure(string procedureName, ExecuteType executeType, IDictionary<string, object> parameters)
        {
            using (SqlConnection _conn = new SqlHelperConnection().connection())
            {
                try
                {
                    object returnObject = null;
                    SqlCommand Command = new SqlCommand(procedureName, _conn)
                    {
                        CommandType = CommandType.StoredProcedure,
                    };
                    if (parameters != null)
                    {
                        Command.Parameters.Clear();
                        foreach (KeyValuePair<string, object> kvp in parameters)
                        {
                            Command.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                        }
                    }
                    switch (executeType)
                    {
                        case ExecuteType.ExecuteNonQuery:
                            returnObject = Command.ExecuteNonQuery();
                            break;
                        case ExecuteType.ExecuteScalar:
                            returnObject = Command.ExecuteScalar();
                            break;
                    }
                    return returnObject;
                }
                catch (Exception ex)
                {
                    //Logger?.LogError("Error de ejecución en modo sincrono ExecuteProcedure");
                    throw new ArgumentException(ex.Message, ex);
                }
                finally
                {
                    if (_conn.State == ConnectionState.Open)
                    {
                        //Logger?.LogInformation("Cerrando conexión en modo sincrono ExecuteProcedure");
                        _conn.Close();
                    }
                }

            }
        }


        public object Execute(string procedureName, ExecuteType executeType, Dictionary<string, object> parameters)
        {
            using (SqlConnection _conn = new SqlHelperConnection().connection())
            {
                try
                {
                    object returnObject = null;
                    using (SqlCommand Command = new SqlCommand(procedureName, _conn))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            Command.Parameters.Clear();
                            foreach (KeyValuePair<string, object> kvp in parameters)
                            {
                                Command.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                            }
                        }
                        switch (executeType)
                        {
                            case ExecuteType.ExecuteNonQuery:
                                returnObject = Command.ExecuteNonQuery();
                                break;
                            case ExecuteType.ExecuteScalar:
                                returnObject = Command.ExecuteScalar();
                                break;
                        }
                    }
                    return returnObject;
                }
                catch (Exception ex)
                {
                    // Logger?.LogError($"Error en ejecución del siguiente Procedimiento {procedureName} se produjo el siguiente error: {ex.Message}");
                    throw new ArgumentException(ex.Message, ex);

                }
                finally
                {
                    if (_conn.State == ConnectionState.Open)
                    {
                        //Logger?.LogInformation("Cerrando conexión en modo sincrono Execute");
                        _conn.Close();
                    }
                }
            }
        }


        public static T DelegadoAccion<T>(SqlDataReader dr) where T : class, new()
        {
            T obj = new T();
            for (int i = 0; i < dr.FieldCount; i++)
            {
                PropertyInfo property = obj.GetType().GetProperty(dr.GetName(i), BindingFlags.SetProperty | BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

                if (!dr.IsDBNull(i) && property != null)
                {

                    if (property.PropertyType == typeof(System.Byte[]))
                    {
                        property.SetValue(obj, dr.GetByte(i), null);
                    }

                    switch (Type.GetTypeCode(property.PropertyType))
                    {
                        case TypeCode.String:
                            property.SetValue(obj, dr.GetString(i), null);
                            break;
                        case TypeCode.Int16:
                            property.SetValue(obj, (object)dr.GetFieldType(i) == typeof(int) ? dr.GetInt32(i) : (int)dr.GetInt64(i), null);
                            break;
                        //case TypeCode.Int32:
                        //    property.SetValue(obj, (object)dr.GetFieldType(i) == typeof(int) ? dr.GetInt32(i) : (int)dr.GetInt64(i), null);
                        //    break;
                        case TypeCode.Int32:
                            property.SetValue(obj, Convert.ToInt32(dr.GetInt32(i)), null);
                            break;
                        case TypeCode.Int64:
                            property.SetValue(obj, (int)dr.GetInt64(i), null);
                            break;
                        case TypeCode.Boolean:
                            property.SetValue(obj, dr.GetBoolean(i), null);
                            break;
                        case TypeCode.Double:
                            property.SetValue(obj, dr.GetDouble(i), null);
                            break;
                        case TypeCode.Decimal:
                            property.SetValue(obj, dr.GetDecimal(i), null);
                            break;
                        case TypeCode.Byte:
                            property.SetValue(obj, dr.GetByte(i), null);
                            break;
                        case TypeCode.DateTime:
                            property.SetValue(obj, dr.GetDateTime(i).ToString("yyyy-MM-ddTHH:mm:ss").ToDateTime(), null);
                            break;
                        default:
                            property.SetValue(obj, dr.GetFloat(i), null);
                            break;
                    }
                }
            }
            return obj;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            if (disposing)
            {
                handle.Dispose();
            }
            disposed = true;
        }

        public int ExecuteNonQuery(string procedureName, Dictionary<string, object> parameters)
        {
            int returnObject = 0;
            using (SqlConnection _conn = new SqlHelperConnection().connection())
            {
                using (SqlCommand Command = new SqlCommand(procedureName, _conn))
                {
                    try
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            Command.Parameters.Clear();
                            foreach (KeyValuePair<string, object> kvp in parameters)
                            {
                                Command.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                            }
                        }


                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var v3 = reader.GetString(0);
                                // . . .  
                            }
                        }

                        //var result = retVal.Value;

                        //returnObject = Command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //Logger?.LogError($"Error en ejecución del siguiente Procedimiento {procedureName} se produjo el siguiente error: {ex.Message}");
                        throw new ArgumentException(ex.Message, ex);
                    }
                    finally
                    {
                        if (_conn.State == ConnectionState.Open)
                        {
                            //Logger?.LogInformation("Cerrando conexión en modo sincrono ExecuteNonQuery");
                            _conn.Close();
                        }
                    }
                }

                return returnObject;
            }

        }



        public string ExecuteNonQueryString(string procedureName, Dictionary<string, object> parameters)
        {
            string returnObject = String.Empty;
            using (SqlConnection _conn = new SqlHelperConnection().connection())
            {
                using (SqlCommand Command = new SqlCommand(procedureName, _conn))
                {
                    try
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            Command.Parameters.Clear();
                            foreach (KeyValuePair<string, object> kvp in parameters)
                            {
                                Command.Parameters.Add(new SqlParameter(kvp.Key, kvp.Value));
                            }
                        }


                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                returnObject = reader.GetString(0);
                                // . . .  
                            }
                        }

                        //var result = retVal.Value;

                        //returnObject = Command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //Logger?.LogError($"Error en ejecución del siguiente Procedimiento {procedureName} se produjo el siguiente error: {ex.Message}");
                        throw new ArgumentException(ex.Message, ex);
                    }
                    finally
                    {
                        if (_conn.State == ConnectionState.Open)
                        {
                            //Logger?.LogInformation("Cerrando conexión en modo sincrono ExecuteNonQuery");
                            _conn.Close();
                        }
                    }
                }

                return returnObject.ToString();
            }

        }


        ~SqlHelperFactory()
        {
            Dispose(false);
        }

    }
}