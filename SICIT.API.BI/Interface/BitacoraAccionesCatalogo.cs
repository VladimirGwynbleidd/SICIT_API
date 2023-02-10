using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class BitacoraAccionesCatalogo : ICatalogo<BitacoraAcciones>
    {
        private readonly BitacoraAccionesBI cls = new BitacoraAccionesBI();
        public Success<BitacoraAcciones> Delete(BitacoraAcciones parameters)
        {
            throw new NotImplementedException();
        }

        public Success<BitacoraAcciones> Get(BitacoraAcciones param = null)
        {
            return cls.Get();
        }

        public Success<BitacoraAcciones> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public Success<BitacoraAcciones> Insert(BitacoraAcciones parameters)
        {
            throw new NotImplementedException();
        }

        public Success<BitacoraAcciones> Update(BitacoraAcciones parameters)
        {
            throw new NotImplementedException();
        }
    }
}
