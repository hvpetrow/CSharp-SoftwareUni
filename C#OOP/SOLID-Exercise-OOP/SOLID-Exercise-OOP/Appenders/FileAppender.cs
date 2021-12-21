using SOLID_Exercise_OOP.Layouts;
using SOLID_Exercise_OOP.LogFiles;
using SOLID_Exercise_OOP.ReportLevel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID_Exercise_OOP.Appenders
{
    public class FileAppender : Appender
    {
        //TODO: fix this
        private const string FilePath = "../../../CreatedFiles/output.txt";
        public FileAppender(ILayout layout ,ILogFile logFile )
            :base(layout)
        {
            LogFile = logFile;
        }

        public ILogFile LogFile { get; }

        public override void Append(string dateTime, LogLevel reportLevel, string message)
        {
            string appendMessage = string.Format(Layout.Format,dateTime, reportLevel, message);

            LogFile.Write(message);
            File.AppendAllText(FilePath,appendMessage + Environment.NewLine);     
        }
    }
}
