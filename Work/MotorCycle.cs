using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public class MotorCycle : IVehicle
    {
        public MotorCycle(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int NumberOfWheels { get; set; }
    }
}
