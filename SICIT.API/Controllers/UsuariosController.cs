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
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == true));
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
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == false));
        }


        [HttpPost]
        [Route("Api/Usuarios/Insert")]
        public IHttpActionResult Post([FromBody] Usuarios usuarios)
        {

            ICatalogo<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
            Success<Usuarios> success;

            try
            {
                success = CatalogoUsuarios.Insert(usuarios);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Usuarios - Insert: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }


    }
}
