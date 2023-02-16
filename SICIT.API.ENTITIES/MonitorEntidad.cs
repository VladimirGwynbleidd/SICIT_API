using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.ENTITIES
{
    public class MonitorEntidad
    {
        public decimal NUM_FOLIO { get; set; }
        public decimal ID_PAQUETE { get; set; }
        public decimal ID_ESTATUS { get; set; }
        public string FECH_INI_OPER { get; set; }
        public string FECH_FIN_OPER { get; set; }
        public string FECH_PROP_TERM { get; set; }
        public bool VIG_FLAG { get; set; }
        public string USUARIO { get; set; }
        public decimal REVISADO { get; set; }

    }
}
