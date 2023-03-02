using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class ConsultaCatalogo : IConsultas<TipoConsulta>
    {
        private readonly ConsultasBI cls = new ConsultasBI();

        public Success<TipoConsulta> Add(TipoConsulta parameters)
        {
            throw new NotImplementedException();
        }

        public Success<TipoConsulta> Delete(TipoConsulta parameters)
        {
            throw new NotImplementedException();
        }

        public Success<TipoConsulta> Get(TipoConsulta parameters = null)
        {
            return cls.Get();
        }

        public Success<TipoConsulta> Update(TipoConsulta parameters)
        {
            throw new NotImplementedException();
        }
    }
}
