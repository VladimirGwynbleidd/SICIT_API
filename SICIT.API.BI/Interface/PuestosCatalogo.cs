using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class PuestosCatalogo : ICatalogo<Puestos>
    {
        private readonly PuestosBI cls = new PuestosBI();

        public Success<Puestos> Delete(Puestos parameters)
        {
            throw new NotImplementedException();
        }

        public Success<Puestos> Get(Puestos param = null)
        {
            return cls.Get();
        }

        public Success<Puestos> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public Success<Puestos> Insert(Puestos parameters)
        {
            throw new NotImplementedException();
        }

        public Success<Puestos> Update(Puestos parameters)
        {
            throw new NotImplementedException();
        }
    }
}
