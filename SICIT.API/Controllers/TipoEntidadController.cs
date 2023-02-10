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

        // POST: api/TipoEntidad
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TipoEntidad/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TipoEntidad/5
        public void Delete(int id)
        {
        }
    }
}
