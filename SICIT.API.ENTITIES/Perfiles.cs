using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.ENTITIES
{
    public class Perfiles
    {
        public int ID_PERFIL { get; set; }
        public string DESCRIPCION_PERFIL { get; set; }
        public int VIG_FLAG { get; set; }
        public DateTime FECH_INI_VIG { get; set; }
        public DateTime FECH_FIN_VIG { get; set; }


        ////    Para Bitacorizar    ////
        public string USUARIOSESION { get; set; }
        public string GUID { get; set; }
        public string ACCION { get; set; }
        public int ID_ACTIVIDAD { get; set; }
    }
}
