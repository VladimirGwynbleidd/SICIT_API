using SICIT.API.BI.Interface;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using SICIT.API.UTILITIES;
using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SICIT.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]/[action]")]
    public class AccionController : ApiController
    {

        [HttpPost]
        [Route("Api/Accion/AgregarAccion")]
        public IHttpActionResult AgregarAccion([FromBody] Accion accion)
        {

            IAccion<Accion> CatalogoAccion = new AccionCatalogo();
            Success<Accion> success;

            try
            {
                success = CatalogoAccion.AgregarAccion(accion);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Accion - AgregarAccion: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }

    }
}