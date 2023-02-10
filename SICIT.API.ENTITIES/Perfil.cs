using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.ENTITIES
{
    public class Perfil
    {
        public int ID_PERFIL { get; set; }
        public string DESCRIPCION_PERFIL { get; set; }
        public int VIG_FLAG { get; set; }
        public DateTime FECH_INI_VIG { get; set; }
        public DateTime FECH_FIN_VIG { get; set; }
       
    }
}
