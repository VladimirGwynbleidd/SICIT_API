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
        public Success<BitacoraSesiones> Get(BitacoraSesiones parameters)
        {
            Func<
                FuncionDelegado<BitacoraSesiones>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<BitacoraSesiones>> response = FuncionDelegado<BitacoraSesiones>.obtenerListaResultado;

            Dictionary<string, object> values = new Dictionary<string, object>
            {
                { "@F_FECH_DESDE", parameters.F_FECH_DESDE},
                { "@F_FECH_HASTA", parameters.F_FECH_HASTA },
                //{ "@USUARIO", null },
                //{ "@ACTIVO", null},
            };


            return response(new SqlHelperFactory().ExecuteList<BitacoraSesiones>, ObjetosSQL.sp_ConsultarBitacoraSesionesFechas, values);
        }

        public Success<BitacoraSesiones> ObtenerBitacora()
        {
            Func<
                FuncionDelegado<BitacoraSesiones>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<BitacoraSesiones>> response = FuncionDelegado<BitacoraSesiones>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<BitacoraSesiones>, ObjetosSQL.sp_obtenerBitacoraSesiones, null);
        }

        public Success<BitacoraSesiones> AgregarBitacora(BitacoraSesiones parameters)
        {
            Func<
                FuncionDelegado<BitacoraSesiones>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                BitacoraSesiones,
                Success<BitacoraSesiones>> response = FuncionDelegado<BitacoraSesiones>.obtenerResultadoString;
            Dictionary<string, object> values = new Dictionary<string, object>
            {
                { "@ID_SESION", parameters.ID_SESION },
                { "@USUARIO", parameters.USUARIO },
                { "@DIRECCION_IP", parameters.DIRECCION_IP }
            };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_agregarBitacoraSesiones, values, parameters);
        }

    }
}
