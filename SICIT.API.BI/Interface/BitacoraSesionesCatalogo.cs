using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class BitacoraSesionesCatalogo : IBitacoraSesiones<BitacoraSesiones>
    {
        private readonly BitacoraSesionesBI cls = new BitacoraSesionesBI();

        public Success<BitacoraSesiones> ObtenerBitacora(BitacoraSesiones param = null)
        {
            return cls.ObtenerBitacora();
        }

        public Success<BitacoraSesiones> AgregarBitacora(BitacoraSesiones parameters)
        {
            return cls.AgregarBitacora(parameters);
        }

        public Success<BitacoraSesiones> Get(BitacoraSesiones parameters)
        {
            return cls.Get(parameters);
        }

        public Success<BitacoraSesiones> Add(BitacoraSesiones parameters)
        {
            throw new NotImplementedException();
        }

        public Success<BitacoraSesiones> Update(BitacoraSesiones parameters)
        {
            throw new NotImplementedException();
        }

        public Success<BitacoraSesiones> Delete(BitacoraSesiones parameters)
        {
            throw new NotImplementedException();
        }
    }
}
