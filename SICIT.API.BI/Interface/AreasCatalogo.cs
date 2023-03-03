using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class AreasCatalogo : IAreas<Areas>
    {
        private readonly AreasBI cls = new AreasBI();
        public Success<Areas> Delete(Areas parameters)
        {
            return cls.Delete(parameters);
        }

        public Success<Areas> Get(Areas param = null)
        {
            return cls.Get();
        }

        public Success<Areas> GetById(Areas parameters)
        {
            return cls.GetById(parameters);
        }

        public Success<Areas> Insert(Areas parameters)
        {
            return cls.Insert(parameters);
        }

        public Success<Areas> Update(Areas parameters)
        {
            return cls.Update(parameters);
        }
    }
}
