using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.ENTITIES
{
    public class Puestos
    {
        public int ID_PUESTO { get; set; }
        public string DESCRIPCION_PUESTO { get; set; }
        public string DESC_T_ENT { get; set; }
        public string SIGLAS_ENT { get; set; }
        public int VIG_FLAG { get; set; }
        public string DESC_AREA { get; set; }
        public int ID_T_ENT { get; set; }
        public int CVE_ID_ENT { get; set; }
        public int ID_AREA { get; set; }


        ////    Para Bitacorizar    ////
        public string USUARIOSESION { get; set; }
        public string GUID { get; set; }
        public string ACCION { get; set; }
        public int ID_ACTIVIDAD { get; set; }
    }
}
