using System;
using System.Web.Http;
using System.Web.Http.Cors;
using SICIT.API.BI.Interface;
using SICIT.API.ENTITIES;
using SICIT.API.Interface;
using SICIT.API.UTILITIES;

namespace SICIT.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]/[action]")]
    public class ParametrosController : ApiController
    {
        [HttpGet]
        [Route("Api/Parametros/ObtenerParametros")]
        public IHttpActionResult ObtenerParametros()
        {
            IParametros<Parametros> CatalogoParametros = new ParametrosCatalogo();
            Success<Parametros> success;

            try
            {
                success = CatalogoParametros.ObtenerParametros();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Parametros - ObtenerParametros: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.InnerException.Message);
            }
            return Json(success);
        }
    }
}