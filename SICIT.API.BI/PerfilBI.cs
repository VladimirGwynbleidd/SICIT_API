using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;

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

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.AGREGAR_PERFIL;
            parameters.ACCION = MensajesBitacora.mensajePerfilInsertar;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@DESCRIPCION_PERFIL", parameters.DESCRIPCION_PERFIL},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }
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

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.MODIFICAR_PERFIL;
            parameters.ACCION = string.Format(MensajesBitacora.mensajePerfilEditar, parameters.ID_PERFIL);

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_PERFIL", parameters.ID_PERFIL},
                        { "@DESCRIPCION_PERFIL", parameters.DESCRIPCION_PERFIL},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }
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

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.ELIMINAR_PERFIL;
            parameters.ACCION = string.Format(MensajesBitacora.mensajePerfilEliminar, parameters.ID_PERFIL);

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_PERFIL", parameters.ID_PERFIL},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }
                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_eliminarPerfil, values, parameters);
        }
    }
}
