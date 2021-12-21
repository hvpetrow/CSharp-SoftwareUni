﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals
{
   public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight,string livingRegion) : base(name, weight)
        {
            
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }

    }
}
