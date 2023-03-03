using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICIT.API.UTILITIES
{
    public static class EventLog
    {
        private static string LOG_SOURCE = "CONSAR.SICITAPI";
        private static int GENERIC_EVENT_ID = 26000;

        public static void WriteEntry(string message, EventLogEntryType eventType)
        {
            System.Diagnostics.EventLog.WriteEntry(LOG_SOURCE, message, eventType, GENERIC_EVENT_ID);
        }
    }
}
