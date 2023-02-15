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
        public Success<Perfiles> Get()
        {
            Func<
                FuncionDelegado<Perfiles>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Perfiles>> response = FuncionDelegado<Perfiles>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<Perfiles>, ObjetosSQL.sp_obtenerPerfil, null);
        }

        public Success<Perfiles> Insert(Perfiles parameters)
        {
            Func<
                FuncionDelegado<Perfiles>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Perfiles,
                Success<Perfiles>> response = FuncionDelegado<Perfiles>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@DESCRIPCION_PERFIL", parameters.DESCRIPCION_PERFIL}

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_insertarPerfil, values, parameters);
        }


        public Success<Perfiles> Update(Perfiles parameters)
        {
            Func<
                FuncionDelegado<Perfiles>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Perfiles,
                Success<Perfiles>> response = FuncionDelegado<Perfiles>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_PERFIL", parameters.ID_PERFIL},
                        { "@DESCRIPCION_PERFIL", parameters.DESCRIPCION_PERFIL}

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_actualizarPerfil, values, parameters);
        }



        public Success<Perfiles> Delete(Perfiles parameters)
        {
            Func<
                FuncionDelegado<Perfiles>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Perfiles,
                Success<Perfiles>> response = FuncionDelegado<Perfiles>.obtenerResultadoString;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_PERFIL", parameters.ID_PERFIL},

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_eliminarPerfil, values, parameters);
        }
    }
}
