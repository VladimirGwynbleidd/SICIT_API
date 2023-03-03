using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;

namespace SICIT.API.BI
{
    public class TipoEntidadBI
    {
        public Success<TipoEntidad> Get()
        {
            Func<
                FuncionDelegado<TipoEntidad>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<TipoEntidad>> response = FuncionDelegado<TipoEntidad>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<TipoEntidad>, ObjetosSQL.sp_obtenerTipoEntidad, null);
        }

        public Success<TipoEntidad> Insert(TipoEntidad parameters)
        {
            Func<
                FuncionDelegado<TipoEntidad>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                TipoEntidad,
                Success<TipoEntidad>> response = FuncionDelegado<TipoEntidad>.obtenerResultadoString;

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.AGREGAR_TIPO_ENTIDAD;
            parameters.ACCION = MensajesBitacora.mensajeTipoEntidadInsertar;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@DESC_T_ENT", parameters.DESC_T_ENT},
                        { "@ESPC_T_ENT", parameters.ESPC_T_ENT},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_InsertarTipoEntidad, values, parameters);
        }


        public Success<TipoEntidad> Update(TipoEntidad parameters)
        {
            Func<
                FuncionDelegado<TipoEntidad>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                TipoEntidad,
                Success<TipoEntidad>> response = FuncionDelegado<TipoEntidad>.obtenerResultadoString;

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.MODIFICAR_TIPO_ENTIDAD;
            parameters.ACCION = string.Format(MensajesBitacora.mensajeTipoEntidadEditar, parameters.ID_T_ENT);

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@DESC_T_ENT", parameters.DESC_T_ENT},
                        { "@ESPC_T_ENT", parameters.ESPC_T_ENT},
                        { "@ID_T_ENT", parameters.ID_T_ENT},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }
                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_ActualizarTipoEntidad, values, parameters);
        }


        public Success<TipoEntidad> Delete(TipoEntidad parameters)
        {
            Func<
                FuncionDelegado<TipoEntidad>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                TipoEntidad,
                Success<TipoEntidad>> response = FuncionDelegado<TipoEntidad>.obtenerResultadoString;

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.ELIMINAR_TIPO_ENTIDAD;
            parameters.ACCION = string.Format(MensajesBitacora.mensajeTipoEntidadEliminar, parameters.ID_T_ENT);

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", parameters.ID_T_ENT},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }
                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.sp_EliminarTipoEntidad, values, parameters);
        }
    }
}
