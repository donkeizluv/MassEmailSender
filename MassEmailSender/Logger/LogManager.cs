using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MassEmailSender.Forms;
using MassEmailSender;

namespace Log
{
    public static class LogManager
    {
        //private const string LogFileName = "log.txt";
        //private static readonly List<string> CacheLogs = new List<string>();
        private static readonly List<ILogger> ListLogger = new List<ILogger>();
        private static readonly object WriteLogLocker = new object();
        public static LogViewer MyLogForm { get; set; }
        //static LogManager()
        //{
        //    IsConsole = false;
        //}

        //private static string LogPath => string.Format(@"{0}\{1}", MassEmailSender.Program.ExeDir, LogFileName);
        //public static bool IsConsole { get; set; }

        public static ILogger GetLogger(Type t)
        {
            var logger = new SimpleLogger(t);
            ListLogger.Add(logger);
            logger.OnNewLog += Logger_OnNewLog;
            return logger;
        }

        private static void Logger_OnNewLog(ILogger log, NewLogEventArgs e)
        {
            if (e.Log == string.Empty) return;
            lock (WriteLogLocker)
            {
                WriteLog(e.Log);
            }
        }

        private static void WriteLog(string log)
        {
           if(MyLogForm != null)
            {
                MyLogForm.AppendLog(log);

            }
        }
    }
}