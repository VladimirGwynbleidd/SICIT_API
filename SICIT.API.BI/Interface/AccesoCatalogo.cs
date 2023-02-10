
using SICIT.API.BI;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;


namespace SINORAPI.BI.Interface
{
    public class AccesoCatalogo : IAcceso<Acceso>
    {
        private readonly AccesoBI cls = new AccesoBI();

        public Success<Acceso> ObtenerAcceso(Acceso parameters)
        {
            return cls.ObtenerAcceso(parameters);
        }

    }
}