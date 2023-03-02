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
    public class ConsultasController : ApiController
    {
        // GET api/<controller>f
        [HttpGet]
        [Route("Api/Consultas/GetTipoConsultas")]
        public IHttpActionResult GetTipoConsultas()
        {

            IConsultas<TipoConsulta> CatalogoTipoConsulta = new ConsultaCatalogo();
            Success<TipoConsulta> success;

            try
            {
                success = CatalogoTipoConsulta.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Consultas - GetTipoConsultas: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}