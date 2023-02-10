using SICIT.API.BI.Interface;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using SICIT.API.UTILITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SICIT.API.Controllers
{
    public class BitacoraSesionesController : ApiController
    {
        // GET: api/BitacoraSesiones
        [HttpGet]
        [Route("Api/BitacoraSesiones/GetBitacoraSesiones")]
        public IHttpActionResult GetBitacoraAcciones()
        {
            ICatalogo<BitacoraSesiones> CatalogoBitacoraSesiones = new BitacoraSesionesCatalogo();
            Success<BitacoraSesiones> success;

            try
            {
                success = CatalogoBitacoraSesiones.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar BitacoraSesiones - GetBitacoraSesiones: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }

        // GET: api/BitacoraSesiones/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BitacoraSesiones
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BitacoraSesiones/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BitacoraSesiones/5
        public void Delete(int id)
        {
        }
    }
}
