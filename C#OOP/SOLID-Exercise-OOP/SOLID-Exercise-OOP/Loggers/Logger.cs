using SOLID_Exercise_OOP.Appenders;
using SOLID_Exercise_OOP.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercise_OOP.Loggers
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appender)
        {
            Appenders = new List<IAppender>();
            Appenders.AddRange(appender);
        }
        public List<IAppender> Appenders { get;}

        public void Critical(string dateTime, string message)
        {
            Log(dateTime,LogLevel.Critical, message);
        }

     

        public void Error(string dateTime, string message)
        {
            Log(dateTime, LogLevel.Error, message);
        }

        public void Fatal(string dateTime, string message)
        {
            Log(dateTime, LogLevel.Fatal, message);
        }

        public void Info(string dateTime, string message)
        {
            Log(dateTime, LogLevel.Info, message);
        }

        public void Warning(string dateTime, string message)
        {
            Log(dateTime, LogLevel.Warning, message);
        }

        private void Log(string dateTime,LogLevel logLevel, string message)
        {
            
            foreach (var append in Appenders)
            {
                if (logLevel >= append.ReportLevel)
                {
                append.Append(dateTime, LogLevel.Critical, message);

                }
            }
        }
    }
}
