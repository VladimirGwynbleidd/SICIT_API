
namespace SICIT.API.ENTITIES
{
    public class Acceso
    {
        public string Usuario { get; set; }
        public string Contra { get; set; }

        public int I_CVE_USUARIO { get; set; }
        public string T_DSC_NOMBRE { get; set; }
        public bool I_FLAG_ESTADO { get; set; }

        public int I_CVE_PERFIL { get; set; }
        public string T_DSC_PERFIL { get; set; }

        public string IP { get; set; }
        public string FQDN { get; set; }
    }
}
