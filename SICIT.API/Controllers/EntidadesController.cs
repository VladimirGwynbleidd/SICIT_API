using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Ajax.Utilities;
using SICIT.API.BI.Interface;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using SICIT.API.UTILITIES;

namespace SICIT.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]/[action]")]
    public class EntidadesController : ApiController
    {
        // GET: api/Entidad
        [HttpGet]
        [Route("Api/Entidades/GetEntidades")]
        public IHttpActionResult GetEntidades()
        {

            ICatalogo<Entidades> CatalogoEntidades = new EntidadesCatalago();
            Success<Entidades> success;

            try
            {
                success = CatalogoEntidades.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Entidades - GetEntidades: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }



        [HttpGet]
        [Route("Api/Entidades/GetEntidadesVigentes")]
        public IHttpActionResult GetEntidadesVigentes()
        {

            ICatalogo<Entidades> CatalogoEntidades = new EntidadesCatalago();
            Success<Entidades> success;

            try
            {
                success = CatalogoEntidades.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Entidades - GetEntidadesVigentes: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == true));
        }



        [HttpGet]
        [Route("Api/Entidades/GetEntidadesHistorial")]
        public IHttpActionResult GetEntidadesHistorial()
        {

            ICatalogo<Entidades> CatalogoEntidades = new EntidadesCatalago();
            Success<Entidades> success;

            try
            {
                success = CatalogoEntidades.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Entidades - GetEntidadesHistorial: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == false));
        }




        [HttpGet]
        [Route("Api/Entidades/GetTipoEntidades")]
        public IHttpActionResult GetTipoEntidades()
        {

            ICatalogo<Entidades> CatalogoEntidades = new EntidadesCatalago();
            Success<Entidades> success;

            try
            {
                success = CatalogoEntidades.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Entidades - GetTipoEntidades: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == true).DistinctBy(x => x.ID_T_ENT));
        }


        // GET: api/Entidades/5
        [HttpPost]
        [Route("Api/Entidades/GetEntidadesById")]
        public IHttpActionResult GetEntidadesById([FromBody] Entidades entidades)
        {

            ICatalogo<Entidades> CatalogoEntidades = new EntidadesCatalago();
            Success<Entidades> success;

            try
            {
                success = CatalogoEntidades.GetId(entidades.ID_T_ENT);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Entidades - GetEntidadesById: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }


        // POST: api/Entidades
        [HttpPost]
        [Route("Api/Entidades/Post")]
        public IHttpActionResult Post([FromBody] Entidades entidades)
        {
            ICatalogo<Entidades> CatalogoEntidades = new EntidadesCatalago();
            Success<Entidades> success;

            try
            {
                success = CatalogoEntidades.Insert(entidades);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Entidades - Post: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // PUT: api/Entidades/Put
        [HttpPut]
        [Route("Api/Entidades/Put")]
        public IHttpActionResult Put([FromBody] Entidades entidades)
        {
            ICatalogo<Entidades> CatalogoEntidades = new EntidadesCatalago();
            Success<Entidades> success;

            try
            {
                success = CatalogoEntidades.Update(entidades);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Entidades - Put: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // DELETE: api/Entidades/Delete
        [HttpDelete]
        [Route("Api/Entidades/Delete")]
        public IHttpActionResult Delete([FromBody] Entidades entidades)
        {
            ICatalogo<Entidades> CatalogoEntidades = new EntidadesCatalago();
            Success<Entidades> success;

            try
            {
                success = CatalogoEntidades.Delete(entidades);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Entidades - Delete: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

    }
}
