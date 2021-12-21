using SOLID_Exercise_OOP.Layouts;
using SOLID_Exercise_OOP.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercise_OOP.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            :base(layout)
        {
        }

        public  override void Append(string dateTime, LogLevel reportLevel, string message)
        {
            string appendMessage = string.Format(Layout.Format, dateTime, reportLevel, message);
            Console.WriteLine(appendMessage);              
        }
    }
}
