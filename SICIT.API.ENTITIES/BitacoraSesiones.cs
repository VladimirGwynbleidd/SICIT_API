using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.ENTITIES
{
    public class BitacoraSesiones
    {
        public string ID_SESION { get; set; }
        public string USUARIO { get; set; }
        public int ID_PERFIL { get; set; }
        public int ID_PUESTO { get; set; }
        public int ID_AREA { get; set; }

        public string DIRECCION_IP { get; set; }
        public string HORA_INICIO { get; set; }
        public string HORA_FIN { get; set; }
        public string FECHA { get; set; }
        public int TIEMPO_VIDA { get; set; }

        public int ACTIVO { get; set; }

        public string F_FECH_DESDE { get; set; }
        public string F_FECH_HASTA { get; set; }




    }
}

