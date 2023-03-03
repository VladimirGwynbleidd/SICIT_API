using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.ENTITIES
{
    public class Entidades
    {
        public int ID_T_ENT { get; set; }
        public int CVE_ID_ENT { get; set; }
        public string DESC_ENT { get; set; }
        public string SIGLAS_ENT { get; set; }
        public bool VIG_FLAG { get; set; }
        public string DESC_T_ENT { get; set; }

        public DateTime FECH_INI_VIG { get; set; }
        public DateTime FECH_FIN_VIG { get; set; }


        ////    Para Bitacorizar    ////
        public string USUARIOSESION { get; set; }
        public string GUID { get; set; }
        public string ACCION { get; set; }
        public int ID_ACTIVIDAD { get; set; }

    }
}
