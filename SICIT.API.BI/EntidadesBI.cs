using SICIT.API.DAL;
using SICIT.API.ENTITIES;
using System;
using System.Collections.Generic;

namespace SICIT.API.BI
{
    public class EntidadesBI
    {
        public Success<Entidades> Get()
        {
            Func<
                FuncionDelegado<Entidades>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Entidades>> response = FuncionDelegado<Entidades>.obtenerListaResultado;
            return response(new SqlHelperFactory().ExecuteList<Entidades>, ObjetosSQL.spGetEntidades, null);
        }


        public Success<Entidades> GetId(int id)
        {
            Func<
                FuncionDelegado<Entidades>.ObtenerResultado,
                string,
                IDictionary<string, object>,
                Success<Entidades>> response = FuncionDelegado<Entidades>.obtenerListaResultado;


            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", id},

                    };

            return response(new SqlHelperFactory().ExecuteList<Entidades>, ObjetosSQL.spGetIdEntidades, values);
        }


        public Success<Entidades> Insert(Entidades parameters)
        {
            Func<
                FuncionDelegado<Entidades>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Entidades,
                Success<Entidades>> response = FuncionDelegado<Entidades>.obtenerResultadoString;

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.AGREGAR_ENTIDAD;
            parameters.ACCION = MensajesBitacora.mensajeEntidadInsertar;

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT", parameters.CVE_ID_ENT},
                        { "@DESC_ENT", parameters.DESC_ENT},
                        { "@SIGLAS_ENT", parameters.SIGLAS_ENT},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.spInsertEntidades, values, parameters);
        }


        public Success<Entidades> Update(Entidades parameters)
        {
            Func<
                FuncionDelegado<Entidades>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Entidades,
                Success<Entidades>> response = FuncionDelegado<Entidades>.obtenerResultadoString;

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.MODIFICAR_ENTIDAD;
            parameters.ACCION = string.Format(MensajesBitacora.mensajeEntidadEditar, parameters.ID_T_ENT);

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT", parameters.CVE_ID_ENT},
                        { "@DESC_ENT", parameters.DESC_ENT},
                        { "@SIGLAS_ENT", parameters.SIGLAS_ENT},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.spUpdateEntidades, values, parameters);
        }



        public Success<Entidades> Delete(Entidades parameters)
        {
            Func<
                FuncionDelegado<Entidades>.ObtenerResultadoString,
                string,
                Dictionary<string, object>,
                Entidades,
                Success<Entidades>> response = FuncionDelegado<Entidades>.obtenerResultadoString;

            parameters.ID_ACTIVIDAD = (int)Enums.Actividad.ELIMINAR_ENTIDAD;
            parameters.ACCION = string.Format(MensajesBitacora.mensajeEntidadEliminar, parameters.ID_T_ENT);

            Dictionary<string, object> values = new Dictionary<string, object>
                    {
                        { "@ID_T_ENT", parameters.ID_T_ENT},
                        { "@CVE_ID_ENT", parameters.CVE_ID_ENT},

                        { "@T_DSC_USUARIOSESION", parameters.USUARIOSESION },
                        { "@T_DSC_SESION", parameters.GUID },
                        { "@T_DSC_ACCION", parameters.ACCION },
                        { "@ID_ACTIVIDAD", parameters.ID_ACTIVIDAD }

                    };

            return response(new SqlHelperFactory().ExecuteNonQueryString, ObjetosSQL.spDeleteEntidades, values, parameters);
        }

    }
}
