using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Hierarchy
{
    internal class Bus : Vehicle
    {
        public int Capacity;
        public Bus(string brand, int speed, int capacity):base(brand,speed)
        {
            Capacity = capacity;
        }
        public void DisplayBus()
        {
            DisplayVehicle();
            Console.WriteLine($"Capacity: {Capacity}");
        }

    }
}
