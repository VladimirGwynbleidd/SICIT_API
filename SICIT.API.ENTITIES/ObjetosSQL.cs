
namespace SICIT.API.ENTITIES
{
    public class ObjetosSQL
    {

        //*******************************************************************************************************
        //*                                         SICIT
        //*
        //*******************************************************************************************************

        //****************************************** ACCESO ***************************************************
        public const string spGetParametros = "SPS_SIC_GRA_PARAMETROS";
        public const string spAcceso = "SPS_NM_SIN_ConsultaAcceso";


        //******************************************ENTIDAD***************************************************
        public const string spGetEntidades = "SPS_SIC_SEG_ENTIDAD";
        public const string spGetIdEntidades = "SPS_SIC_OBTEN_ENTIDAD";
        public const string spInsertEntidades = "SPI_SIC_SEG_ALTA_ENTIDAD";
        public const string spUpdateEntidades = "SPU_SIC_SEG_ACTUALIZA_ENTIDAD";
        public const string spDeleteEntidades = "SPU_SIC_SEG_ELIMINA_ENTIDAD";



        //******************************************USUARIOS***************************************************
        public const string sp_obtenerUsuarios = "SPS_SIC_SEG_USUARIOS";
        public const string sp_InsertUsuario = "SPI_SIC_SEG_USUARIOS";
        public const string sp_ObtenerUsuario = "SPS_SIC_SEG_USUARIOS_GET_USER";
        public const string sp_updateUsuarioUsuarios = "SPU_SIC_SEG_USUARIOS";
        public const string sp_eliminarUsuarioUsuarios = "SPU_SIC_GRAL_USUARIO_BAJA";
        public const string sp_updatePassword = "SPU_SIC_SEG_USUARIOS_PASSWORD";



        //******************************************TIPO ENTIDAD***************************************************
        public const string sp_obtenerTipoEntidad = "SPS_SIC_SEG_CATTIPOENTIDAD";
        public const string sp_InsertarTipoEntidad = "SPI_SIC_T_ENTIDAD";
        public const string sp_ActualizarTipoEntidad = "SPU_SIC_T_ENTIDAD";
        public const string sp_EliminarTipoEntidad = "SPU_SIC_T_BAJA_ENTIDAD";

        //******************************************AREAS***************************************************
        public const string sp_obtenerAreas = "SPS_SIC_SEG_AREAS";
        public const string sp_GetIdAreas = "SPS_SIC_OBTEN_AREA";
        public const string sp_InsertarAreas = "SPI_SIC_SEG_AREAS";
        public const string sp_ActualizarAreas = "SPU_SIC_SEG_AREAS";
        public const string sp_EliminarAreas = "SPU_SIC_SEG_AREAS_BAJA";

        //******************************************PUESTOS***************************************************
        public const string sp_obtenerPuestoID = "SPS_SIC_OBTEN_PUESTO";
        public const string sp_obtenerPuestos = "SPS_SIC_SEG_PUESTOS";
        public const string sp_InsertarPuestos = "SPI_SIC_SEG_ALTA_PUESTO";
        public const string sp_ActualizarPuestos = "SPU_SIC_SEG_ACTUALIZA_PUESTO";
        public const string sp_EliminarPuestos = "SPU_SIC_SEG_ELIMINA_PUESTO";


        //*************************************BITACORA ACCIONES***********************************************
        public const string sp_obtenerBitacoraAcciones = "SPS_SIC_SEG_BITACORA_ACCIONES";
        public const string sp_obtenerBitacoraSesionesFechas = "SPS_SIC_SEG_REGISTRO_SESIONES";


        //******************************************BITACORA SESIONES******************************************
        public const string sp_obtenerBitacoraSesiones = "SPS_SIC_SEG_SESIONES";
        public const string sp_agregarBitacoraSesiones = "SPI_SIC_GRA_BITACORA_SESION";
        public const string sp_ConsultarBitacoraSesionesFechas = "SPS_SIC_GRA_BITACORA_SESION";


        //******************************************Perfil***************************************************
        public const string sp_obtenerPerfil = "SPS_SIC_SEG_PERFIL";
        public const string sp_insertarPerfil = "SPI_SIC_SEG_ALTA_PERFIL";
        public const string sp_actualizarPerfil = "SPU_SIC_SEG_ACTUALIZA_PERFIL";
        public const string sp_eliminarPerfil = "SPU_SIC_SEG_ELIMINA_PERFIL";

        //******************************************MONITOR***************************************************
        public const string sp_obtenerMonitor = "SPS_SIC_MEN_MONITOR";

        //******************************************MONITOR***************************************************
        public const string sp_obtenerTipoConsulta = "SPS_SIC_CON_PAQUETES";

        //******************************************ACCION***************************************************
        public const string sp_AgregarAccion = "SPI_SIC_SEG_BITACORA_ACCIONES";


    }
}
