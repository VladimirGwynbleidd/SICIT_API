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


        public Success<Areas> GetById(Areas parameters)
        {
            Func<
                FuncionDelegado<Areas>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Areas>> response = FuncionDelegado<Areas>.obtenerListaResultado;


            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT", parameters.CVE_ID_ENT},

                    };

            return response(new SqlHelperFactory().ExecuteList<Areas>, ObjetosSQL.sp_GetIdAreas, values);
        }
    }
}
