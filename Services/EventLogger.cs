using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Interfaces;

namespace Services
{
    public class EventLogger : IAppLogger
    {
        private readonly string SourceName = "REMS_App";

        private readonly string LogName = "Application";
        public EventLogger()
        {
            if (!EventLog.SourceExists(SourceName))
                EventLog.CreateEventSource(SourceName, LogName);
        }
        public void LogInfo(string Message)
        {
            EventLog.WriteEntry(this.SourceName, Message, EventLogEntryType.Information);
        }
        public void LogWarning(string Message)
        {
            EventLog.WriteEntry(this.SourceName, Message, EventLogEntryType.Warning);
        }
        public void LogError(string Message, Exception ex = null)
        {
            string text = ((ex == null) ? string.Empty : ex.Message);
            string text2 = ((ex == null) ? string.Empty : ex.StackTrace);
            EventLog.WriteEntry(this.SourceName, "[ERROR] " + Message + Environment.NewLine + "Exception Message : " + text + Environment.NewLine + "StackTrace : " + Environment.NewLine + text2, EventLogEntryType.Error);
        }
    }
}
