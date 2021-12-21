using SOLID_Exercise_OOP.Layouts;
using SOLID_Exercise_OOP.ReportLevel;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercise_OOP.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            Layout = layout;
        }
        public ILayout Layout { get; }
        public LogLevel ReportLevel { get; set ; }

        public abstract void Append(
            string dateTime,
            LogLevel reportLevel,
            string message);

    }
}
