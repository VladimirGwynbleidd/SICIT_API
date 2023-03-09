using SICIT.API.ENTITIES;
using SICIT.API.Interface;

namespace SICIT.API.BI.Interface
{
    public class ParametrosCatalogo : IParametros<Parametros>
    {
        private readonly ParametrosBI cls = new ParametrosBI();

        public Success<Parametros> ObtenerParametros(Parametros param = null)
        {
            return cls.ObtenerParametros();
        }
    }
}
