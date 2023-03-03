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
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]/[action]")]
    public class PuestosController : ApiController
    {
        // GET: api/Puestos
        [HttpGet]
        [Route("Api/Puestos/GetPuestos")]
        public IHttpActionResult GetPuestos()
        {
            IPuestos<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Get(null);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - GetPuestos: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }


        [HttpGet]
        [Route("Api/Puestos/GetTipoPuestosVigentes")]
        public IHttpActionResult GetTipoPuestosVigentes()
        {

            IPuestos<Puestos> CatalogpPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogpPuestos.Get(null);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - GetTipoPuestosVigentes: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 1));
        }



        [HttpGet]
        [Route("Api/Puestos/GetTipoPuestosHistorial")]
        public IHttpActionResult GetTipoPuestosHistorial()
        {

            IPuestos<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Get(null);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - GetTipoPuestosHistorial: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 0));
        }


        [HttpPost]
        [Route("Api/Puestos/GetPuestoById")]
        public IHttpActionResult GetPuestoById([FromBody] Puestos puestos)
        {

            IPuestos<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;


            try
            {
                success = CatalogoPuestos.GetId(puestos);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Areas - GetAreasById: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);

        }
        // POST: api/Puestos
        [HttpPost]
        [Route("Api/Puestos/Post")]
        public IHttpActionResult Post([FromBody] Puestos puestos)
        {

            IPuestos<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Insert(puestos);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - Post: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // PUT: api/Puestos/5
        [HttpPut]
        [Route("Api/Puestos/Put")]
        public IHttpActionResult Put([FromBody] Puestos puestos)
        {
            IPuestos<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Update(puestos);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - Put: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // DELETE: api/Puestos/5
        [HttpDelete]
        [Route("Api/Puestos/Delete")]
        public IHttpActionResult Delete([FromBody] Puestos puestos)
        {
            IPuestos<Puestos> CatalogoPuestos = new PuestosCatalogo();
            Success<Puestos> success;

            try
            {
                success = CatalogoPuestos.Delete(puestos);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Puestos - Delete: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }
    }
}
