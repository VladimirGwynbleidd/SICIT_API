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
using System.Web.Http.Cors;

namespace SICIT.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]/[action]")]
    public class BitacoraSesionesController : ApiController
    {
        // GET: api/BitacoraSesiones
        [HttpGet]
        [Route("Api/BitacoraSesiones/GetBitacoraSesiones")]
        public IHttpActionResult GetBitacoraSesiones()
        {
            ICatalogo<BitacoraSesiones> CatalogoBitacoraSesiones = new BitacoraSesionesCatalogo();
            Success<BitacoraSesiones> success;

            try
            {
                success = CatalogoBitacoraSesiones.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar BitacoraSesiones - GetBitacoraSesiones: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }


        // POST: api/GetBitacoraSesionesFechas
        [HttpPost]
        [Route("Api/BitacoraSesiones/GetBitacoraSesionesFechas")]
        public IHttpActionResult GetBitacoraSesionesFechas(BitacoraSesiones bitacora)
        {
            ICatalogo<BitacoraSesiones> CatalogoBitacoraSesiones = new BitacoraSesionesCatalogo();
            Success<BitacoraSesiones> success;


            try
            {
                success = CatalogoBitacoraSesiones.Get(bitacora);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar BitacoraSesiones - GetBitacoraSesionesFechas: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }

        // PUT: api/BitacoraSesiones/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/BitacoraSesiones/5
        public void Delete(int id)
        {
        }
    }
}
