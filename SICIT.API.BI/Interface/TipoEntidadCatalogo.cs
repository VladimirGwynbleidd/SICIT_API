﻿using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.BI.Interface
{
    public class TipoEntidadCatalogo : ICatalogo<TipoEntidad>
    {
        private readonly TipoEntidadBI cls = new TipoEntidadBI();
        public Success<TipoEntidad> Delete(TipoEntidad parameters)
        {
            throw new NotImplementedException();
        }

        public Success<TipoEntidad> Get(TipoEntidad param = null)
        {
            return cls.Get();
        }

        public Success<TipoEntidad> GetId(int id)
        {
            throw new NotImplementedException();
        }

        public Success<TipoEntidad> Insert(TipoEntidad parameters)
        {
            throw new NotImplementedException();
        }

        public Success<TipoEntidad> Update(TipoEntidad parameters)
        {
            throw new NotImplementedException();
        }
    }
}
