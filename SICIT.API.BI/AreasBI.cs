using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI
{
    public class AreasBI
    {
        public Success<Areas> Get()
        {
            Func<
                FuncionDelegado<Areas>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Areas>> response = FuncionDelegado<Areas>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<Areas>, ObjetosSQL.sp_obtenerAreas, null);
        }


        public Success<Areas> GetById(Areas parameters)
        {
            Func<
                FuncionDelegado<Areas>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Areas>> response = FuncionDelegado<Areas>.obtenerListaResultado;


            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT", parameters.CVE_ID_ENT},

                    };

            return response(new SqlHelperFactory().ExecuteList<Areas>, ObjetosSQL.sp_GetIdAreas, values);
        }

        public Success<Areas> Insert(Areas parameters)
        {
            Func<
                FuncionDelegado<Areas>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Areas,
                Success<Areas>> response = FuncionDelegado<Areas>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                { "@ID_T_ENT", parameters.ID_T_ENT},
                { "@CVE_ID_ENT", parameters.CVE_ID_ENT},
                { "@DESC_AREA", parameters.DESC_AREA},

            };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_InsertarAreas, values, parameters);
        }


        public Success<Areas> Update(Areas parameters)
        {
            Func<
                FuncionDelegado<Areas>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Areas,
                Success<Areas>> response = FuncionDelegado<Areas>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                { "@ID_AREA", parameters.ID_AREA},
                { "@ID_T_ENT", parameters.ID_T_ENT},
                { "@CVE_ID_ENT", parameters.CVE_ID_ENT},
                { "@DESC_AREA", parameters.DESC_AREA},

            };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_ActualizarAreas, values, parameters);
        }



        public Success<Areas> Delete(Areas parameters)
        {
            Func<
                FuncionDelegado<Areas>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Areas,
                Success<Areas>> response = FuncionDelegado<Areas>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_AREA", parameters.ID_AREA},
                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_EliminarAreas, values, parameters);
        }
    }
}
