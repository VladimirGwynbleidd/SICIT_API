
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
        public const string spInsertEntidades = "SPI_SIC_SEG_ENTIDAD";
        public const string spUpdateEntidades = "SPU_SIC_SEG_ENTIDAD";
        public const string spDeleteEntidades = "SPU_SIC_SEG_ENTIDAD_BAJA";



        //******************************************USUARIOS***************************************************
        public const string sp_obtenerUsuarios = "SPS_SIC_SEG_USUARIOS";


        //******************************************TIPO ENTIDAD***************************************************
        public const string sp_obtenerTipoEntidad = "SPS_SIC_SEG_CATTIPOENTIDAD";

        //******************************************AREAS***************************************************
        public const string sp_obtenerAreas = "SPS_SIC_SEG_AREAS";

        //******************************************PUESTOS***************************************************
        public const string sp_obtenerPuestos = "SPS_SIC_SEG_PUESTOS";


        //******************************************BITACORA***************************************************
        public const string sp_obtenerBitacoraAcciones = "SPS_SIC_SEG_BITACORA";
        public const string sp_obtenerBitacoraSesiones = "SPS_SIC_SEG_SESIONES";


        //******************************************Perfil***************************************************
        public const string sp_obtenerPerfil = "SPS_SIC_SEG_PERFIL";

    }
}
