using System;
using System.Linq;
using System.Runtime.CompilerServices;
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
                EventLog.WriteEntry("Error al ejecutar Entidades - GetEntidades: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == true).DistinctBy(x => x.CVE_ID_ENT));
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
                EventLog.WriteEntry("Error al ejecutar Entidades - GetEntidadesVigentes: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
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
                EventLog.WriteEntry("Error al ejecutar Entidades - GetEntidadesHistorial: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
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
                EventLog.WriteEntry("Error al ejecutar Usuarios - ObtenerUsuarios: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.Where(x => x.VIG_FLAG == true).DistinctBy(x => x.ID_T_ENT));
        }


        // GET: api/Entidades/5
        public string Get(int id)
        {
            return "value";
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
                EventLog.WriteEntry("Error al ejecutar Usuarios - ObtenerUsuarios: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success




                );
        }

        // PUT: api/Entidades/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Entidades/5
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
                EventLog.WriteEntry("Error al ejecutar Usuarios - ObtenerUsuarios: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success




                );
        }

    }
}
