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
    public class BitacoraSesionesController : ApiController
    {
        // GET: api/BitacoraSesiones
        [HttpGet]
        [Route("Api/BitacoraSesiones/GetBitacoraSesiones")]
        public IHttpActionResult GetBitacoraSesiones()
        {
            IBitacoraSesiones<BitacoraSesiones> CatalogoBitacoraSesiones = new BitacoraSesionesCatalogo();
            Success<BitacoraSesiones> success;

            try
            {
                success = CatalogoBitacoraSesiones.ObtenerBitacora();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar BitacoraSesiones - GetBitacoraSesiones: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }



        // POST: api/GetBitacoraSesionesFechas
        [HttpPost]
        [Route("Api/BitacoraSesiones/GetBitacoraSesionesFechas")]
        public IHttpActionResult GetBitacoraSesionesFechas(BitacoraSesiones bitacora)
        {
            IBitacoraSesiones<BitacoraSesiones> CatalogoBitacoraSesiones = new BitacoraSesionesCatalogo();
            Success<BitacoraSesiones> success;


            try
            {
                success = CatalogoBitacoraSesiones.Get(bitacora);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar BitacoraSesiones - GetBitacoraSesionesFechas: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable);
        }


        [HttpPost]
        [Route("Api/BitacoraSesiones/AgregarBitacora")]
        public IHttpActionResult AgregarBitacora([FromBody] BitacoraSesiones bitacora)
        {

            IBitacoraSesiones<BitacoraSesiones> CatalogoBitacoraSesiones = new BitacoraSesionesCatalogo();
            Success<BitacoraSesiones> success;

            try
            {
                success = CatalogoBitacoraSesiones.AgregarBitacora(bitacora);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar BitacoraSesiones - AgregarBitacora: " + ex.InnerException.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success);
        }
    }
}
