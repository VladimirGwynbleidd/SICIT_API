using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;

namespace SICIT.API.BI
{
    public class TipoEntidadBI
    {
        public Success<TipoEntidad> Get()
        {
            Func<
                FuncionDelegado<TipoEntidad>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<TipoEntidad>> response = FuncionDelegado<TipoEntidad>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<TipoEntidad>, ObjetosSQL.sp_obtenerTipoEntidad, null);
        }
    }
}
