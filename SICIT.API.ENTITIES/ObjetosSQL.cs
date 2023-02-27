
namespace SICIT.API.ENTITIES
{
    public class ObjetosSQL
    {
        public const string BitacoraNormatividad = "SPS_SIN_INF_ASOC_BITACORA";
        
        public const string sp_obtenerPerfiles = "SPS_SIN_NM_PERFIL";
        public const string sp_updateUsuario = "SPU_SIN_ACTUALIZA_USUARIO";
        public const string sp_agregaUsuario = "SPI_SIN_AGREGA_USUARIO";
        public const string sp_eliminarUsuario = "SPU_SIN_ELIMINA_USUARIO";
        public const string sp_obtenerArchivoNormatividad = "SPS_SIN_NM_ARCHIVO_NORMATIVA";
        public const string sp_obtenerArchivoAsociada = "SPS_SIN_NM_ARCHIVO_ASO";
        public const string sp_obtenerAsociacionesNormatividad = "SPS_SIN_NM_ASOCIADA";
        public const string sp_agregaInfoAsociacion = "SPI_SIN_NM_INFO_ASOC";
        public const string sp_actualizaAsociada = "SPU_SIN_NM_ACTUALIZA_ASOCIADA";
        public const string sp_eliminaAsociada = "SPU_SIN_NM_ELIMINA_ASOCIADA";
        public const string sp_actualizaNormatividad = "SPU_SIN_NM_ACTUALIZA_NORMATIVIDAD";
        public const string sp_eliminaNormatividad = "SPU_SIN_NM_ELIMINA_NORMATIVIDAD";
        public const string sp_obtenerNormatividadParametros = "SP_CON_CONSULTA_NORMATIVIDAD";
        public const string sp_actualizaPublicacion = "SPU_SIN_NM_PUBLICA";
        public const string sp_agregaConfigMicrositio = "SPI_SIN_AGREGA_MICROSITIO";
        public const string sp_ObtienePreguntaFrecuente = "SPS_SIN_NM_PREGUNTA";
        public const string sp_agregaPreguntaFrecuente = "SPI_SIN_NM_PREGUNTA";
        public const string sp_obtenerArchivoPregunta = "SPS_SIN_NM_ARCHIVO_PREGUNTA";
        public const string sp_actualizaEstadoPregunta = "SPU_SIN_NM_PREGUNTA";
        public const string sp_obtenerConfigMicrositio = "SPS_SIN_NM_MICROSITIO";
        public const string sp_obtenerCabecerosMicrositio = "SPS_SIN_NM_MICROSITIO";
        public const string sp_obtenerBitacoraNormatividad = "SPS_SIN_BITACORA_NORMATIVIDAD";
        public const string sp_obtenerBitacoraAsociacion = "SPS_SIN_BITACORA_ASOC_INF";
        public const string sp_obtenerBitacoraPregunta = "SPS_SIN_BITACORA_PREGUNTA";
        public const string sp_obtenerBitacoraMicrositio = "SPS_SIN_BITACORA_MICROSITIO";

        public const string spAcceso = "SPS_NM_SIN_ConsultaAcceso";




        //*******************************************************************************************************
        //*                                         SICIT
        //*
        //*******************************************************************************************************


        public const string spGetEntidades = "SPS_SIC_SEG_ENTIDAD";
        public const string spGetIdEntidades = "SPS_SIC_OBTEN_ENTIDAD";
        public const string spInsertEntidades = "SPI_SIC_SEG_ALTA_ENTIDAD";
        public const string spUpdateEntidades = "SPU_SIC_SEG_ACTUALIZA_ENTIDAD";
        public const string spDeleteEntidades = "SPU_SIC_SEG_ELIMINA_ENTIDAD";



        //******************************************USUARIOS***************************************************
        public const string sp_obtenerUsuarios = "SPS_SIC_SEG_USUARIOS";
        public const string sp_InsertUsuario = "";



        //******************************************TIPO ENTIDAD***************************************************
        public const string sp_obtenerTipoEntidad = "SPS_SIC_SEG_CATTIPOENTIDAD";
        public const string sp_InsertarTipoEntidad = "SPI_SIC_T_ENTIDAD";
        public const string sp_ActualizarTipoEntidad = "SPU_SIC_T_ENTIDAD";
        public const string sp_EliminarTipoEntidad = "SPU_SIC_T_BAJA_ENTIDAD";

        //******************************************AREAS***************************************************
        public const string sp_obtenerAreas = "SPS_SIC_SEG_AREAS";
        public const string sp_GetIdAreas = "SPS_SIC_OBTEN_AREA";
        public const string sp_InsertarAreas= "SPI_SIC_SEG_AREAS";
        public const string sp_ActualizarAreas = "SPU_SIC_SEG_AREAS";
        public const string sp_EliminarAreas = "SPU_SIC_SEG_AREAS_BAJA";

        //******************************************PUESTOS***************************************************
        public const string sp_obtenerPuestoID = "SPS_SIC_OBTEN_PUESTO";
        public const string sp_obtenerPuestos = "SPS_SIC_SEG_PUESTOS";
        public const string sp_InsertarPuestos = "SPI_SIC_SEG_ALTA_PUESTO";
        public const string sp_ActualizarPuestos = "SPU_SIC_SEG_ACTUALIZA_PUESTO";
        public const string sp_EliminarPuestos = "SPU_SIC_SEG_ELIMINA_PUESTO";


        //******************************************BITACORA***************************************************
        public const string sp_obtenerBitacoraAcciones = "SPS_SIC_SEG_BITACORA";
        public const string sp_obtenerBitacoraSesiones = "SPS_SIC_SEG_SESIONES";


        //******************************************Perfil***************************************************
        public const string sp_obtenerPerfil = "SPS_SIC_SEG_PERFIL";
        public const string sp_insertarPerfil = "SPI_SIC_SEG_ALTA_PERFIL";
        public const string sp_actualizarPerfil = "SPU_SIC_SEG_ACTUALIZA_PERFIL";
        public const string sp_eliminarPerfil = "SPU_SIC_SEG_ELIMINA_PERFIL";

        //******************************************MONITOR***************************************************
        public const string sp_obtenerMonitor = "SPS_SIC_MEN_MONITOR";

    }
}
