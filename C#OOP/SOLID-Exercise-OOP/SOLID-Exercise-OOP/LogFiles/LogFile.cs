using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLID_Exercise_OOP.LogFiles
{
    public class LogFile : ILogFile
    {
        private StringBuilder sb;
        public LogFile()
        {
            sb = new StringBuilder();

        }
        public int Size => sb.ToString().Where(s => char.IsLetter(s)).Sum(c=>c);

        public void Write(string message)
            => sb.Append(message);
    }
}
