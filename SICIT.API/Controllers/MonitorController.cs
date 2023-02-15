﻿using System;
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
    public class MonitorController : ApiController
    {
        [HttpGet]
        [Route("api/Monitor/GetMonitor")]
        public IHttpActionResult GetMonitor()
        {

            ICatalogo<MonitorEntidad> CatalogoMonitor = new MonitorCatalogo();
            Success<MonitorEntidad> success;

            try
            {
                success = CatalogoMonitor.Get();
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry("Error al ejecutar Monitor - GetMonitor: " + ex.Message, System.Diagnostics.EventLogEntryType.Error);
                throw new Exception(ex.Message);
            }
            return Json(success.ResponseDataEnumerable.DistinctBy(x => x.NUM_FOLIO));
        }
    }
}
