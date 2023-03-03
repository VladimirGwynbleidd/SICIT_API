using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI
{
    public class BitacoraAccionesBI
    {
        public Success<BitacoraAcciones> Get()
        {
            Func<
                FuncionDelegado<BitacoraAcciones>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<BitacoraAcciones>> response = FuncionDelegado<BitacoraAcciones>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<BitacoraAcciones>, ObjetosSQL.sp_obtenerBitacoraAcciones, null);
        }
    }
}
