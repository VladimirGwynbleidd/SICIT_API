using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI
{
    public class PuestosBI
    {
        public Success<Puestos> Get()
        {
            Func<
                FuncionDelegado<Puestos>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Puestos>> response = FuncionDelegado<Puestos>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<Puestos>, ObjetosSQL.sp_obtenerPuestos, null);
        }

        public Success<Puestos> Insert(Puestos parameters)
        {
            Func<
                FuncionDelegado<Puestos>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Puestos,
                Success<Puestos>> response = FuncionDelegado<Puestos>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        //{ "@ID_PUESTO", parameters.ID_PUESTO},
                        { "@DESCRIPCION_PUESTO", parameters.DESCRIPCION_PUESTO},
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT ", parameters.CVE_ID_ENT},
                        { "@ID_AREA", parameters.ID_AREA}

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_InsertarPuestos, values, parameters);
        }


        public Success<Puestos> GetById(Puestos parameters)
        {
            Func<
                FuncionDelegado<Puestos>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Puestos>> response = FuncionDelegado<Puestos>.obtenerListaResultado;


            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@ID_AREA",parameters.ID_AREA },
                        { "@CVE_ID_ENT",parameters.CVE_ID_ENT },
                    };

            return response(new SqlHelperFactory().ExecuteList<Puestos>, ObjetosSQL.sp_obtenerPuestoID, values);
        }


        public Success<Puestos> Update(Puestos parameters)
        {
            Func<
                FuncionDelegado<Puestos>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Puestos,
                Success<Puestos>> response = FuncionDelegado<Puestos>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_PUESTO", parameters.ID_PUESTO},
                        { "@DESCRIPCION_PUESTO", parameters.DESCRIPCION_PUESTO},
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT ", parameters.CVE_ID_ENT},
                        { "@ID_AREA", parameters.ID_AREA}

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_ActualizarPuestos, values, parameters);
        }


        public Success<Puestos> Delete(Puestos parameters)
        {
            Func<
                FuncionDelegado<Puestos>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Puestos,
                Success<Puestos>> response = FuncionDelegado<Puestos>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_PUESTO", parameters.ID_PUESTO},
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT ", parameters.CVE_ID_ENT},
                        { "@ID_AREA", parameters.ID_AREA}

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_EliminarPuestos, values, parameters);
        }
    }
}
