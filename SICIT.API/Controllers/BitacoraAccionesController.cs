using SICIT.API.BI.Interface;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using SICIT.API.UTILITIES;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SICIT.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]/[action]")]
    public class BitacoraAccionesController : ApiController
    {
        // GET: api/BitacoraAcciones
        [HttpGet]
        [Route("Api/BitacoraAcciones/GetBitacoraAcciones")]
        public IHttpActionResult GetBitacoraAcciones()
        {
            ICatalogo<BitacoraAcciones> CatalogoBitacoraAcciones = new BitacoraAccionesCatalogo();
            Success<BitacoraAcciones> success;

            try
            {
                success = CatalogoBitacoraAcciones.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Areas - GetAreas: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }

        // GET: api/BitacoraAcciones/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BitacoraAcciones
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/BitacoraAcciones/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BitacoraAcciones/5
        public void Delete(int id)
        {
        }
    }
}
