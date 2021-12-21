using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Exercise_OOP.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
