using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI
{
    public class BitacoraSesionesBI
    {
        public Success<BitacoraSesiones> Get()
        {
            Func<
                FuncionDelegado<BitacoraSesiones>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<BitacoraSesiones>> response = FuncionDelegado<BitacoraSesiones>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<BitacoraSesiones>, ObjetosSQL.sp_obtenerBitacoraSesiones, null);
        }
    }
}
