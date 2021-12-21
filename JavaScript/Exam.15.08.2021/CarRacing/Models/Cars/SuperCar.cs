﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Cars
{
    public class SuperCar : Car
    {
        public SuperCar(string make, string model, string VIN, int horsePower)
            : base(make, model, VIN, horsePower, 80, 10)
        {

        }

        public override void Drive()
        {
            base.Drive();
            Math.Round(HorsePower * 0.97);
        }
    }
}
