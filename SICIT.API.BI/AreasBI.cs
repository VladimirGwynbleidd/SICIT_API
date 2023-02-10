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
    }
}
