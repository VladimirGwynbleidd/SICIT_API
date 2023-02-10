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
            ICatalogo<Perfil> CatalogoPerfil= new PerfilCatalogo();
            Success<Perfil> success;

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
            ICatalogo<Perfil> CatalogoPerfil = new PerfilCatalogo();
            Success<Perfil> success;

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
            ICatalogo<Perfil> CatalogoPerfil = new PerfilCatalogo();
            Success<Perfil> success;

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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Perfiles/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Perfiles/5
        public void Delete(int id)
        {
        }
    }
}
