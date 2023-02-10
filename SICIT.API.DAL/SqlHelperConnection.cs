
using SICIT.API.UTILITIES;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace SICIT.API.DAL
{
    public class SqlHelperConnection
    {
        private static string Password_string { get => Environment.GetEnvironmentVariable("COVOL_PASSWORD_SQL").ToString(); }

        private static SecureString Password_secureString
        {
            get
            {
                SecureString passwordSql = new SecureString();
                Password_string.ToCharArray().ToList().ForEach(p => passwordSql.AppendChar(p));
                passwordSql.MakeReadOnly();

                return passwordSql;
            }
        }

        private static SqlCredential credential_sql
        {
            get
            {
                return new SqlCredential(Environment.GetEnvironmentVariable("COVOL_USER_SQL"), Password_secureString);
            }
        }

        private static string Connection_string
        {
            get
            {
                string strConx = string.Empty;

                if (Convert.ToBoolean(ConfigurationManager.AppSettings["Desarrollo"].ToString()) == true)
                    strConx = ConfigurationManager.AppSettings["DesarrolloCITIC"].ToString();
                else
                    strConx = ConfigurationManager.AppSettings["ProduccionCITIC"].ToString();

                return Cifrado.Desencriptar(strConx);
                //return ConfigurationManager.ConnectionStrings["SINOR"].ConnectionString;
            }
        }

        public async Task<SqlConnection> connectionAsync()
        {
            SqlConnection conn = new SqlConnection(Connection_string, credential_sql);
            await conn.OpenAsync();
            return conn;
        }

        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(Connection_string);
            conn.Open();
            return conn;
        }

    }
}