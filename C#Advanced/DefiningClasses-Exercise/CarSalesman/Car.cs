﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = @"n/a";
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine, weight)
        {
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {  this.Engine.Power}");
            
            if (this.Engine.Displacement == 0)
            {
                sb.AppendLine("    Displacement: n/a");
            }

            else
            {
                sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
            }

            sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            if (this.Weight == 0)
            {
                sb.AppendLine("  Weight: n/a");
            }

            else
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }

            sb.AppendLine($"  Color: { this.Color}");
            return sb.ToString().Trim();


        }
    }
}
