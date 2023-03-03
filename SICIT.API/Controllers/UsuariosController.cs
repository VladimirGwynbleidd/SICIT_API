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
        [HttpPost]
        [Route("Api/Usuarios/ResetPassword")]
        public IHttpActionResult ResetPassword([FromBody] Usuarios usuarios)
        {

            IUsuarios<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
            Success<Usuarios> success;

            try
            {
                success = CatalogoUsuarios.ResetPassword(usuarios);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Usuarios - GetUsuarios: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }


        [HttpGet]
        [Route("Api/Usuarios/GetUsuarios")]
        public IHttpActionResult GetUsuarios()
        {

            IUsuarios<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
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

            IUsuarios<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
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

            IUsuarios<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
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

            IUsuarios<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
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


        [HttpPost]
        [Route("Api/Usuarios/Update")]
        public IHttpActionResult Put([FromBody] Usuarios usuarios)
        {

            IUsuarios<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
            Success<Usuarios> success;

            try
            {
                success = CatalogoUsuarios.Update(usuarios);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Usuarios - Update: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }


        [HttpPost]
        [Route("Api/Usuarios/GetUsuarioById")]
        public IHttpActionResult GetUsuarioById([FromBody] Usuarios usuario)
        {

            IUsuarios<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
            Success<Usuarios> success;

            try
            {
                success = CatalogoUsuarios.GetId(usuario.USUARIO);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Usuarios - GetEntidadesById: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }


        [HttpPost]
        [Route("Api/Usuarios/DeleteUsuario")]
        public IHttpActionResult Delete([FromBody] Usuarios usuarios)
        {
            IUsuarios<Usuarios> CatalogoUsuarios = new UsuariosCatalogo();
            Success<Usuarios> success;

            try
            {
                success = CatalogoUsuarios.Delete(usuarios);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Usuarios - Delete: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }


    }
}
