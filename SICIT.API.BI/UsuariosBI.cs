using System;
using System.Collections.Generic;
using SICIT.API.ENTITIES;
using SICIT.API.DAL;
using SICIT.API.UTILITIES;

namespace SICIT.API.BI
{
    public class UsuariosBI
    {
        public Success<Usuarios> Get()
        {
            Func<
                FuncionDelegado<Usuarios>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Usuarios>> response = FuncionDelegado<Usuarios>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<Usuarios>, ObjetosSQL.sp_obtenerUsuarios, null);
        }

        public Success<Usuarios> GetUser(string id)
        {
            Func<
                FuncionDelegado<Usuarios>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Usuarios>> response = FuncionDelegado<Usuarios>.obtenerListaResultado;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@USUARIO", id}
                    };

            return response(new SqlHelperFactory().ExecuteList<Usuarios>, ObjetosSQL.sp_ObtenerUsuario, values);
        }


        public Success<Usuarios> Insert(Usuarios parameters)
        {
            Func<
                FuncionDelegado<Usuarios>.ObtenerResultadoEscalar,
                string,
                Dictionary<string, object>,
                Usuarios,
                Success<Usuarios>> response = FuncionDelegado<Usuarios>.obtenerResultado;

            string encrypt = HashPassword.CreatePassword(parameters.USUARIO);

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.AGREGAR_USUARIO;
            parameters.ACCION = MensajesBitacora.mensajeUsuarioInsertar;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@USUARIO", parameters.USUARIO},
                        { "@ID_PERFIL", parameters.ID_PERFIL},
                        { "@ID_PUESTO", parameters.ID_PUESTO },
                        { "@ID_AREA", parameters.ID_AREA},
                        { "@CVE_ID_ENT", parameters.CVE_ID_ENT},
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CONTRASENA", encrypt},
                        { "@NOMBRES", parameters.NOMBRES},
                        { "@APELLIDO_PATERNO", parameters.APELLIDO_PATERNO},
                        { "@APELLIDO_MATERNO", parameters.APELLIDO_MATERNO},
                        { "@TELEFONO", parameters.TELEFONO},
                        { "@EMAIL", parameters.EMAIL},
                        { "@PRIMERA_SESION", 1},
                        { "@ENVIO_EMAIL", 1},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }
                    };

            return response(new SqlHelperFactory().ExecuteNonQuery, ObjetosSQL.sp_InsertUsuario, values, parameters);
        }

        public Success<Usuarios> Update(Usuarios parameters)
        {
            Func<
                FuncionDelegado<Usuarios>.ObtenerResultadoEscalar,
                string,
                Dictionary<string, object>,
                Usuarios,
                Success<Usuarios>> response = FuncionDelegado<Usuarios>.obtenerResultado;

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.MODIFICAR_USUARIO;
            parameters.ACCION = string.Format(MensajesBitacora.mensajeUsuarioEditar, parameters.USUARIO);

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@USUARIO", parameters.USUARIO},
                        { "@ID_PERFIL", parameters.ID_PERFIL},
                        { "@ID_PUESTO", parameters.ID_PUESTO},
                        { "@ID_T_ENT", parameters.ID_T_ENT },
                        { "@CVE_ID_ENT", parameters.CVE_ID_ENT},
                        { "@NOMBRES", parameters.NOMBRES},
                        { "@APELLIDO_PATERNO", parameters.APELLIDO_PATERNO},
                        { "@APELLIDO_MATERNO", parameters.APELLIDO_MATERNO},
                        { "@TELEFONO", parameters.TELEFONO},
                        { "@EMAIL", parameters.EMAIL},
                        { "@PRIMERA_SESION", 0},
                        { "@ENVIO_EMAIL", 1},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }
                    };

            return response(new SqlHelperFactory().ExecuteNonQuery, ObjetosSQL.sp_updateUsuarioUsuarios, values, parameters);
        }

        public Success<Usuarios> Delete(Usuarios parameters)
        {
            Func<
                FuncionDelegado<Usuarios>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Usuarios,
                Success<Usuarios>> response = FuncionDelegado<Usuarios>.obtenerResultadoString;

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.ELIMINAR_USUARIO;
            parameters.ACCION = string.Format(MensajesBitacora.mensajeUsuarioEliminar, parameters.USUARIO);

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@USUARIO", parameters.USUARIO},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }
                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_eliminarUsuarioUsuarios, values, parameters);
        }

        public Success<Usuarios> UpdatePassword(Usuarios parameters)
        {
            Func<
                FuncionDelegado<Usuarios>.ObtenerResultadoEscalar,
                string,
                Dictionary<string, object>,
                Usuarios,
                Success<Usuarios>> response = FuncionDelegado<Usuarios>.obtenerResultado;

            string encrypt = string.Empty;
            if (string.IsNullOrEmpty(parameters.CONTRASENA))
            {
                encrypt = HashPassword.CreatePassword(parameters.USUARIO);
                parameters.PRIMERA_SESION = 1;
            }
            else
            {
                encrypt = parameters.CONTRASENA;
            }

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@USUARIO", parameters.USUARIO},
                        { "@CONTRASENA", encrypt},
                        { "@PRIMERA_SESION", parameters.PRIMERA_SESION}
                    };

            return response(new SqlHelperFactory().ExecuteNonQuery, ObjetosSQL.sp_updatePassword, values, parameters);
        }

    }
}