using SOLID_Exercise_OOP.Appenders;
using SOLID_Exercise_OOP.Layouts;
using SOLID_Exercise_OOP.LogFiles;
using SOLID_Exercise_OOP.Loggers;
using System;

namespace SOLID_Exercise_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var simpleLayout = new Xml();
            var consoleAppender = new ConsoleAppender(simpleLayout);

            var file = new LogFile();
            var fileAppender = new FileAppender(simpleLayout, file);

            var logger = new Logger(consoleAppender, fileAppender);
            logger.Error("3/26/2015 2:08:11 PM", "Error parsing JSON.");
            logger.Info("3/26/2015 2:08:11 PM", "User Pesho successfully registered.");
        }
    }
}
