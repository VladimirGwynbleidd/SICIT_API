using SICIT.API.BI;
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
    public class TipoEntidadController : ApiController
    {
        // GET: api/TipoEntidad
        [HttpGet]
        [Route("Api/TipoEntidad/GetTipoEntidad")]
        public IHttpActionResult GetTipoEntidad()
        {
            ICatalogo<TipoEntidad> CatalogoTipoEntidad = new TipoEntidadCatalogo();
            Success<TipoEntidad> success;

            try
            {
                success = CatalogoTipoEntidad.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar TipoEntidad - GetTipoEntidad: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }

        [HttpGet]
        [Route("Api/TipoEntidad/GetTipoEntidadVigentes")]
        public IHttpActionResult GetTipoEntidadVigentes()
        {

            ICatalogo<TipoEntidad> CatalogoTipoEntidad = new TipoEntidadCatalogo();
            Success<TipoEntidad> success;

            try
            {
                success = CatalogoTipoEntidad.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar TipoEntidad - GetTipoEntidadVigentes: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 1));
        }



        [HttpGet]
        [Route("Api/TipoEntidad/GetTipoEntidadHistorial")]
        public IHttpActionResult GetTipoEntidadHistorial()
        {

            ICatalogo<TipoEntidad> CatalogoTipoEntidad = new TipoEntidadCatalogo();
            Success<TipoEntidad> success;

            try
            {
                success = CatalogoTipoEntidad.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar TipoEntidad - GetTipoEntidadHistorial: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 0));
        }

        // GET: api/TipoEntidad/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TipoEntidad/Post
        [HttpPost]
        [Route("Api/TipoEntidad/Post")]
        public IHttpActionResult Post([FromBody] TipoEntidad tipoEntidad)
        {

            ICatalogo<TipoEntidad> CatalogoTipoEntidad= new TipoEntidadCatalogo();
            Success<TipoEntidad> success;

            try
            {
                success = CatalogoTipoEntidad.Insert(tipoEntidad);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar TipoEntidad - Insert: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // PUT: api/TipoEntidad/5
        [HttpPut]
        [Route("Api/TipoEntidad/Put")]
        public IHttpActionResult Put([FromBody] TipoEntidad tipoEntidad)
        {
            ICatalogo<TipoEntidad> CatalogoTipoEntidad = new TipoEntidadCatalogo();
            Success<TipoEntidad> success;

            try
            {
                success = CatalogoTipoEntidad.Update(tipoEntidad);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar TipoEntidad - Update: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // DELETE: api/TipoEntidad/5
        [HttpDelete]
        [Route("Api/TipoEntidad/Delete")]
        public IHttpActionResult Delete([FromBody] TipoEntidad tipoEntidad)
        {
            ICatalogo<TipoEntidad> CatalogoTipoEntidad = new TipoEntidadCatalogo();
            Success<TipoEntidad> success;

            try
            {
                success = CatalogoTipoEntidad.Delete(tipoEntidad);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar TipoEntidad - Delete: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }
    }
}
