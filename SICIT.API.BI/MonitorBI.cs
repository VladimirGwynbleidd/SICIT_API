using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;


namespace SICIT.API.BI.Interface
{
    public class MonitorBI
    {
        public Success<MonitorEntidad> Get()
        {
            Func<
                FuncionDelegado<MonitorEntidad>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<MonitorEntidad>> response = FuncionDelegado<MonitorEntidad>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<MonitorEntidad>, ObjetosSQL.sp_obtenerMonitor, null);
        }
    }
}
