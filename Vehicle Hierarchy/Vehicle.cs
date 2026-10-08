using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Hierarchy
{
    internal class Vehicle
    {
        public string Brand;
        protected int Speed;

        public Vehicle(string brand,int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public void DisplayVehicle()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {Speed}");
        }    
    }
}
