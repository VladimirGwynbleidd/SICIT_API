using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;

namespace SICIT.API.BI
{
    public class EntidadesBI
    {
        public Success<Entidades> Get()
        {
            Func<
                FuncionDelegado<Entidades>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Entidades>> response = FuncionDelegado<Entidades>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<Entidades>, ObjetosSQL.spGetEntidades, null);
        }


        public Success<Entidades> Insert(Entidades parameters)
        {
            Func<
                FuncionDelegado<Entidades>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Entidades,
                Success<Entidades>> response = FuncionDelegado<Entidades>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT", parameters.CVE_ID_ENT},
                        { "@DESC_ENT", parameters.DESC_ENT},
                        { "@SIGLAS_ENT", parameters.SIGLAS_ENT}

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.spInsertEntidades, values, parameters);
        }



        public Success<Entidades> Delete(Entidades parameters)
        {
            Func<
                FuncionDelegado<Entidades>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Entidades,
                Success<Entidades>> response = FuncionDelegado<Entidades>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT", parameters.CVE_ID_ENT},
                        { "@DESC_ENT", string.Empty},
                        { "@SIGLAS_ENT", string.Empty}

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.spDeleteEntidades, values, parameters);
        }

    }
}
