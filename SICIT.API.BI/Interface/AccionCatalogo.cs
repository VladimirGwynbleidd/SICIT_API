using SICIT.API.ENTITIES;
using SICIT.API.Interface;

namespace SICIT.API.BI.Interface
{
    public class AccionCatalogo : IAccion<Accion>
    {
        private readonly AccionBI cls = new AccionBI();

        public Success<Accion> AgregarAccion(Accion parameters)
        {
            return cls.AgregarAccion(parameters);
        }
    }
}