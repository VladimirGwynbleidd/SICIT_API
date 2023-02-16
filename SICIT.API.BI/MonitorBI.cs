using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;


namespace SICIT.API.BI.Interface
{
    public class MonitorBI
    {
        public Success<MonitorEntidad> Get(MonitorEntidad param)
        {
            Func<
                FuncionDelegado<MonitorEntidad>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<MonitorEntidad>> response = FuncionDelegado<MonitorEntidad>.obtenerListaResultado;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@USUARIO", param.USUARIO},
                        { "@NUM_FOLIO", param.NUM_FOLIO},
                        { "@REVISADO", param.REVISADO}
                    };

            return response(new SqlHelperFactory().ExecuteList<MonitorEntidad>, ObjetosSQL.sp_obtenerMonitor, values);
        }
    }
}
