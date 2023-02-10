using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI
{
    public class PerfilBI
    {
        public Success<Perfil> Get()
        {
            Func<
                FuncionDelegado<Perfil>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Perfil>> response = FuncionDelegado<Perfil>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<Perfil>, ObjetosSQL.sp_obtenerPerfil, null);
        }
    }
}
