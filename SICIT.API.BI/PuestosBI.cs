using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI
{
    public class PuestosBI
    {
        public Success<Puestos> Get()
        {
            Func<
                FuncionDelegado<Puestos>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Puestos>> response = FuncionDelegado<Puestos>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<Puestos>, ObjetosSQL.sp_obtenerPuestos, null);
        }
    }
}
