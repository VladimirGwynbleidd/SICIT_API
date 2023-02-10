using SICIT.API.BI.Interface;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using SICIT.API.UTILITIES;
using SICIT.BI.Interface;
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
    public class AreasController : ApiController
    {
        // GET: api/Areas
        [HttpGet]
        [Route("Api/Areas/GetAreas")]
        public IHttpActionResult GetAreas()
        {
            ICatalogo<Areas> CatalogoAreas= new AreasCatalogo();
            Success<Areas> success;

            try
            {
                success = CatalogoAreas.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Areas - GetAreas: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }



        [HttpGet]
        [Route("Api/Areas/GetTipoAreasVigentes")]
        public IHttpActionResult GetTipoAreasVigentes()
        {

            ICatalogo<Areas> CatalogoAreas = new AreasCatalogo();
            Success<Areas> success;

            try
            {
                success = CatalogoAreas.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Areas - GetTipoAreasVigentes: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 1));
        }



        [HttpGet]
        [Route("Api/Areas/GetTipoAreasHistorial")]
        public IHttpActionResult GetTipoAreasHistorial()
        {

            ICatalogo<Areas> CatalogoAreas = new AreasCatalogo();
            Success<Areas> success;

            try
            {
                success = CatalogoAreas.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Areas - GetTipoAreasHistorial: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 0));
        }


        // GET: api/Areas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Areas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Areas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Areas/5
        public void Delete(int id)
        {
        }
    }
}
