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



        public Success<BitacoraSesiones> Get(BitacoraSesiones parameters)
        {
            Func<
                FuncionDelegado<BitacoraSesiones>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<BitacoraSesiones>> response = FuncionDelegado<BitacoraSesiones>.obtenerListaResultado;


            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@FECHA_INICIO", parameters.FECHA_INICIO},
                        { "@FECHA_FIN", parameters.FECHA_FIN},
                        { "@USUARIO", parameters.USUARIO},
                        { "@ACTIVO", parameters.ACTIVO},
                    };

            return response(new SqlHelperFactory().ExecuteList<BitacoraSesiones>, ObjetosSQL.sp_obtenerBitacoraSesionesFechas, values);
        }
    }
}
