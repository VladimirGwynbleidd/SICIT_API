using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;

namespace SICIT.API.BI.Interface
{
    public class EntidadesCatalago : ICatalogo<Entidades>
    {
        private readonly EntidadesBI cls = new EntidadesBI();

        public Success<Entidades> Insert(Entidades parameters)
        {
            return cls.Insert(parameters);
        }


        public Success<Entidades> Delete(Entidades parameters)
        {
            return cls.Delete(parameters);
        }


        public Success<Entidades> Get(Entidades param = null)
        {
            return cls.Get();
        }

        public Success<Entidades> GetId(int id)
        {
            return cls.GetId(id);
        }


        public Success<Entidades> Update(Entidades parameters)
        {
            throw new NotImplementedException();
        }
    }
}
