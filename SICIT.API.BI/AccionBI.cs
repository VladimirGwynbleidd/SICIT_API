using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;

namespace SICIT.API.BI
{
    public class AccionBI
    {
        public Success<Accion> AgregarAccion(Accion parameters)
        {
            Func<
                FuncionDelegado<Accion>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Accion,
                Success<Accion>> response = FuncionDelegado<Accion>.obtenerResultadoString;
            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }
                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_AgregarAccion, values, parameters);
        }
    }
}
