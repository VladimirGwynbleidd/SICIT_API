using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI
{
    public class ConsultasBI
    {
        public Success<TipoConsulta> Get()
        {
            Func<
                FuncionDelegado<TipoConsulta>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<TipoConsulta>> response = FuncionDelegado<TipoConsulta>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<TipoConsulta>, ObjetosSQL.sp_obtenerTipoConsulta, null);
        }
    }
}
