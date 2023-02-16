using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class MonitorCatalogo : ICatalogo<MonitorEntidad>
    {

        private readonly MonitorBI cls = new MonitorBI();

        public Success<MonitorEntidad> Get(MonitorEntidad param = null)
        {
           return cls.Get(param);
        }

        public Success<MonitorEntidad> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public Success<MonitorEntidad> Insert(MonitorEntidad parameters)
        {
            throw new NotImplementedException();
        }

        public Success<MonitorEntidad> Update(MonitorEntidad parameters)
        {
            throw new NotImplementedException();
        }

        public Success<MonitorEntidad> Delete(MonitorEntidad parameters)
        {
            throw new NotImplementedException();
        }
    }
}
