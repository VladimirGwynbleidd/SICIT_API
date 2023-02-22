using SICIT.API.BI;
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
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    [Route("api/[controller]/[action]")]
    public class PuestosController : ApiController
    {
        // GET: api/Puestos
        [HttpGet]
        [Route("Api/Puestos/GetPuestos")]
        public IHttpActionResult GetPuestos()
        {
            ICatalogo<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - GetPuestos: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }


        [HttpGet]
        [Route("Api/Puestos/GetTipoPuestosVigentes")]
        public IHttpActionResult GetTipoPuestosVigentes()
        {

            ICatalogo<Puestos> CatalogpPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogpPuestos.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - GetTipoPuestosVigentes: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 1));
        }



        [HttpGet]
        [Route("Api/Puestos/GetTipoPuestosHistorial")]
        public IHttpActionResult GetTipoPuestosHistorial()
        {

            ICatalogo<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - GetTipoPuestosHistorial: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 0));
        }


        // GET: api/Puestos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Puestos
        [HttpPost]
        [Route("Api/Puestos/Post")]
        public IHttpActionResult Post([FromBody]Puestos puestos)
        {

            ICatalogo<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Insert(puestos);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Perfiles - Insert: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // PUT: api/Puestos/5
        [HttpPut]
        [Route("Api/Puestos/Put")]
        public IHttpActionResult Put([FromBody] Puestos puestos)
        {
            ICatalogo<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Update(puestos);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - Update: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // DELETE: api/Puestos/5
        [HttpDelete]
        [Route("Api/Puestos/Delete")]
        public IHttpActionResult Delete([FromBody] Puestos puestos)
        {
            ICatalogo<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Delete(puestos);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - Delete: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }
    }
}
