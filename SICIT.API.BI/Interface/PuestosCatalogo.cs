using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class PuestosCatalogo : IPuestos<Puestos>
    {
        private readonly PuestosBI cls = new PuestosBI();



        public Success<Puestos> Delete(Puestos parameters)
        {
            return cls.Delete(parameters);
        }

        public Success<Puestos> Get(Puestos param = null)
        {
            return cls.Get();
        }


        //public Success<Puestos> GetById(Puestos parameters)
        //{

        //}

        public Success<Puestos> GetId(Puestos parameters)
        {
            return cls.GetById(parameters);
        }

        public Success<Puestos> Insert(Puestos parameters)
        {
            return cls.Insert(parameters);
        }

        public Success<Puestos> Update(Puestos parameters)
        {
            return cls.Update(parameters);
        }
    }
}
