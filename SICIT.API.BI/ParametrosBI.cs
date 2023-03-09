using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;

namespace SICIT.API.BI
{
    public class ParametrosBI
    {
        public Success<Parametros> ObtenerParametros()
        {
            Func<
                FuncionDelegado<Parametros>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Parametros>> response = FuncionDelegado<Parametros>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<Parametros>, ObjetosSQL.spGetParametros, null);
        }

    }
}
