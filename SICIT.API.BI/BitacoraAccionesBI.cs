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
        public Success<BitacoraAcciones> Get(BitacoraAcciones parameters)
        {
            Func<
                FuncionDelegado<BitacoraAcciones>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<BitacoraAcciones>> response = FuncionDelegado<BitacoraAcciones>.obtenerListaResultado;


            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@fecha_inicial", DateTime.Parse(parameters.fecha_inicial) },
                        { "@fecha_final", DateTime.Parse(parameters.fecha_final) },
                        { "@USUARIO", parameters.USUARIO},
                        { "@EVENTO", parameters.EVENTO},
                    };

            return response(new SqlHelperFactory().ExecuteList<BitacoraAcciones>, ObjetosSQL.sp_obtenerBitacoraAcciones, values);
        }
    }
}
