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
            IAreas<Areas> CatalogoAreas= new AreasCatalogo();
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

            IAreas<Areas> CatalogoAreas = new AreasCatalogo();
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

            IAreas<Areas> CatalogoAreas = new AreasCatalogo();
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


        // POST: api/Areas/5
        [HttpPost]
        [Route("Api/Areas/GetAreasById")]
        public IHttpActionResult GetAreasById([FromBody] Areas areas)
        {

            IAreas<Areas> CatalogoAreas = new AreasCatalogo();
            Success<Areas> success;

            try
            {
                success = CatalogoAreas.GetById(areas);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Areas - GetAreasById: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }

        // POST: api/Areas/Post
        [HttpPost]
        [Route("Api/Areas/Post")]
        public IHttpActionResult Post([FromBody] Areas areas)
        {

            IAreas<Areas> CatalogoAreas = new AreasCatalogo();
            Success<Areas> success;

            try
            {
                success = CatalogoAreas.Insert(areas);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Areas - Insert: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // PUT: api/Areas/5
        [HttpPut]
        [Route("Api/Areas/Put")]
        public IHttpActionResult Put([FromBody] Areas areas)
        {
            IAreas<Areas> CatalogoAreas = new AreasCatalogo();
            Success<Areas> success;

            try
            {
                success = CatalogoAreas.Update(areas);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Areas - Update: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // DELETE: api/Areas/5
        [HttpDelete]
        [Route("Api/Areas/Delete")]
        public IHttpActionResult Delete([FromBody] Areas areas)
        {
            IAreas<Areas> CatalogoAreas = new AreasCatalogo();
            Success<Areas> success;

            try
            {
                success = CatalogoAreas.Delete(areas);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Areas - Delete: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }
    }
}
