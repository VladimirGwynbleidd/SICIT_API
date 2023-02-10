using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;

namespace SICIT.API.BI
{
    public class AccesoBI
    {
        public Success<Acceso> ObtenerAcceso(Acceso acceso)
        {
            Func<
                FuncionDelegado<Acceso>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Acceso>> response = FuncionDelegado<Acceso>.obtenerListaResultado;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@T_DSC_USUARIO", acceso.Usuario}
                    };

            return response(new SqlHelperFactory().ExecuteList<Acceso>, ObjetosSQL.spAcceso, values);
        }

    }
}
