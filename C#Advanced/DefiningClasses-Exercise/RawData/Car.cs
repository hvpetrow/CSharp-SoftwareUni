using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Car
    {
        public Car(string model , Cargo cargo , Engine engine , List<Tire> tires)
        {
            Model = model;
            Cargo = cargo;
            Engine = engine;
            Tires = tires;
        }
        public string Model { get; set; }
        public  Cargo Cargo { get; set; }

        public Engine Engine{ get; set; }

        public List<Tire> Tires{ get; set; }


    }
}
