﻿using System;

namespace Car
{
   public class Car 
    {
      
        public  string Make { get; set; }

        public string Model{ get; set; }

        private int year;
        public  int Year 
        {           
            get
            {
                return year;
            }
            
            set
            {
                year = value;
            }
         }

    }
   public class StartUp
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Make = "VW";
            car1.Model = "MK3";
            car1.Year = 1992;

            Console.WriteLine($"Make: {car1.Make}\nModel: {car1.Model}\nYear: {car1.Year}");


        }
    }
}
