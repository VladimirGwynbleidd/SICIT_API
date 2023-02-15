using SICIT.API.BI;
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
    public class PerfilesController : ApiController
    {
        // GET: api/Perfiles
        [HttpGet]
        [Route("Api/Perfil/GetPerfil")]
        public IHttpActionResult GetPerfil()
        {
            ICatalogo<Perfiles> CatalogoPerfil= new PerfilesCatalogo();
            Success<Perfiles> success;

            try
            {
                success = CatalogoPerfil.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Perfil - GetPerfil: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }

        [HttpGet]
        [Route("Api/Perfil/GetTipoPerfilVigentes")]
        public IHttpActionResult GetTipoPerfilVigentes()
        {
            ICatalogo<Perfiles> CatalogoPerfil = new PerfilesCatalogo();
            Success<Perfiles> success;

            try
            {
                success = CatalogoPerfil.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Perfil - GetTipoPuestosVigentes: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 1));
        }



        [HttpGet]
        [Route("Api/Perfil/GetTipoPerfilHistorial")]
        public IHttpActionResult GetTipoPerfilHistorial()
        {
            ICatalogo<Perfiles> CatalogoPerfil = new PerfilesCatalogo();
            Success<Perfiles> success;

            try
            {
                success = CatalogoPerfil.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Perfil - GetTipoPuestosHistorial: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 0));
        }

        // GET: api/Perfiles/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Perfiles
        [HttpPost]
        [Route("Api/Perfiles/Post")]
        public IHttpActionResult Post([FromBody] Perfiles perfiles)
        {
            ICatalogo<Perfiles> CatalogoPerfiles = new PerfilesCatalogo();
            Success<Perfiles> success;

            try
            {
                success = CatalogoPerfiles.Insert(perfiles);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Perfiles - Insert: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // PUT: api/Perfiles/5
        [HttpPut]
        [Route("Api/Perfiles/Put")]
        public IHttpActionResult Put([FromBody] Perfiles perfiles)
        {
            ICatalogo<Perfiles> CatalogoPerfiles = new PerfilesCatalogo();
            Success<Perfiles> success;

            try
            {
                success = CatalogoPerfiles.Update(perfiles);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Perfiles - Put: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

        // DELETE: api/Perfiles/5
        [HttpDelete]
        [Route("Api/Perfiles/Delete")]
        public IHttpActionResult Delete([FromBody] Perfiles perfiles)
        {
            ICatalogo<Perfiles> CatalogoPerfiles = new PerfilesCatalogo();
            Success<Perfiles> success;

            try
            {
                success = CatalogoPerfiles.Delete(perfiles);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Perfiles - Delete: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }
    }
}
