using System;
using SICIT.API.ENTITIES;
using System.Web.Http;
using System.Web.Http.Cors;
using SICIT.BI.Interface;
using SICIT.API.UTILITIES;
using SICIT.API.Interface;
using SICIT.API.BI.Interface;
using System.Linq;

namespace SICIT.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]/[action]")]
    public class UsuariosController : ApiController
    {
        // GET: api/Usuarios
        [HttpGet]
        [Route("Api/Usuarios/GetUsuarios")]
        public IHttpActionResult GetUsuarios()
        {

            ICatalogo<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
            Success<Usuarios> success;

            try
            {
                success = CatalogoUsuarios.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Usuarios - GetUsuarios: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }




        [HttpGet]
        [Route("Api/Usuarios/GetUsuariosVigentes")]
        public IHttpActionResult GetUsuariosVigentes()
        {

            ICatalogo<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
            Success<Usuarios> success;

            try
            {
                success = CatalogoUsuarios.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Usuarios - GetUsuariosVigentes: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 1));
        }



        [HttpGet]
        [Route("Api/Usuarios/GetUsuariosHistorial")]
        public IHttpActionResult GetUsuariosHistorial()
        {

            ICatalogo<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
            Success<Usuarios> success;

            try
            {
                success = CatalogoUsuarios.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Usuarios - GetUsuariosHistorial: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == 0));
        }


        // GET: api/Usuarios/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuarios
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuarios/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuarios/5
        public void Delete(int id)
        {
        }
    }
}
