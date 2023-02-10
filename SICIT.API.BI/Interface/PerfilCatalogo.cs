using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class PerfilCatalogo : ICatalogo<Perfil>
    {
        private readonly PerfilBI cls = new PerfilBI();
        public Success<Perfil> Delete(Perfil parameters)
        {
            throw new NotImplementedException();
        }

        public Success<Perfil> Get(Perfil param = null)
        {
            return cls.Get();
        }

        public Success<Perfil> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public Success<Perfil> Insert(Perfil parameters)
        {
            throw new NotImplementedException();
        }

        public Success<Perfil> Update(Perfil parameters)
        {
            throw new NotImplementedException();
        }
    }
}
