using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class BitacoraSesionesCatalogo : ICatalogo<BitacoraSesiones>
    {
        private readonly BitacoraSesionesBI cls = new BitacoraSesionesBI();
        public Success<BitacoraSesiones> Delete(BitacoraSesiones parameters)
        {
            throw new NotImplementedException();
        }

        public Success<BitacoraSesiones> Get(BitacoraSesiones param = null)
        {
            return cls.Get();
        }

        public Success<BitacoraSesiones> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public Success<BitacoraSesiones> Insert(BitacoraSesiones parameters)
        {
            throw new NotImplementedException();
        }

        public Success<BitacoraSesiones> Update(BitacoraSesiones parameters)
        {
            throw new NotImplementedException();
        }
    }
}
