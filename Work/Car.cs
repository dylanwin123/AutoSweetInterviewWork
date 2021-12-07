using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Car : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int NumberOfWheels { get; set; }
    }
}
