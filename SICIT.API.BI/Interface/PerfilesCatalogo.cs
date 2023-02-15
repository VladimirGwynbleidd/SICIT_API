using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class PerfilesCatalogo : ICatalogo<Perfiles>
    {
        private readonly PerfilBI cls = new PerfilBI();
        public Success<Perfiles> Delete(Perfiles parameters)
        {
            return cls.Delete(parameters);
        }

        public Success<Perfiles> Get(Perfiles param = null)
        {
            return cls.Get();
        }

        public Success<Perfiles> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public Success<Perfiles> Insert(Perfiles parameters)
        {
            return cls.Insert(parameters);
        }

        public Success<Perfiles> Update(Perfiles parameters)
        {
            return cls.Update(parameters);
        }
    }
}
