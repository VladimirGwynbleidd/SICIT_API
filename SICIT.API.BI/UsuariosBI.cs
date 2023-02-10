using System;
using System.Collections.Generic;
using SICIT.API.ENTITIES;
using SICIT.API.DAL;

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

        //public Success<Usuarios> Agregar(Usuarios parameters)
        //{
        //    Func<
        //        FuncionDelegado<Usuarios>.ObtenerResultadoEscalar,
        //        string,
        //        Dictionary<string, object>,
        //        Usuarios,
        //        Success<Usuarios>> response = FuncionDelegado<Usuarios>.obtenerResultado;

        //    Dictionary<string, object> values = new Dictionary<string, object>
        //            {
        //                { "@T_DSC_USUARIO", parameters.T_DSC_USUARIO},
        //                { "@T_DSC_NOMBRE", parameters.T_DSC_NOMBRE},
        //                { "@T_DSC_APEIDOPATERNO", parameters.T_DSC_APEIDOPATERNO },
        //                { "@T_DSC_APEIDOMATERNO", parameters.T_DSC_APEIDOMATERNO},
        //                { "@I_CVE_PERFIL", parameters.I_CVE_PERFIL}
        //            };

        //    return response(new SqlHelperFactory().ExecuteNonQuery, ObjetosSQL.sp_agregaUsuario, values, parameters);
        //}

        //public Success<Usuarios> Actualizar(Usuarios parameters)
        //{
        //    Func<
        //        FuncionDelegado<Usuarios>.ObtenerResultadoEscalar,
        //        string,
        //        Dictionary<string, object>,
        //        Usuarios,
        //        Success<Usuarios>> response = FuncionDelegado<Usuarios>.obtenerResultado;

        //    Dictionary<string, object> values = new Dictionary<string, object>
        //            {                      
        //                { "@I_CVE_USUARIO", parameters.I_CVE_USUARIO},
        //                { "@T_DSC_USUARIO", parameters.T_DSC_USUARIO},
        //                { "@T_DSC_NOMBRE", parameters.T_DSC_NOMBRE},
        //                { "@T_DSC_APEIDOPATERNO", parameters.T_DSC_APEIDOPATERNO },
        //                { "@T_DSC_APEIDOMATERNO", parameters.T_DSC_APEIDOMATERNO},
        //                { "@I_CVE_PERFIL", parameters.I_CVE_PERFIL}
        //            };

        //    return response(new SqlHelperFactory().ExecuteNonQuery, ObjetosSQL.sp_updateUsuario, values, parameters);
        //}

        //public Success<Usuarios> Eliminar(Usuarios parameters)
        //{
        //    Func<
        //        FuncionDelegado<Usuarios>.ObtenerResultadoEscalar,
        //        string,
        //        Dictionary<string, object>,
        //        Usuarios,
        //        Success<Usuarios>> response = FuncionDelegado<Usuarios>.obtenerResultado;

        //    Dictionary<string, object> values = new Dictionary<string, object>
        //            {
        //                { "@I_CVE_USUARIO", parameters.I_CVE_USUARIO},
        //            };

        //    return response(new SqlHelperFactory().ExecuteNonQuery, ObjetosSQL.sp_eliminarUsuario, values, parameters);
        //}

    }
}