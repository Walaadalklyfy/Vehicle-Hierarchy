using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Hierarchy
{
    internal class Car:Vehicle
    {
        public int NumberOfDoors;
        public Engine MyEngine;
        public Car(string brand, int speed,int doors):base(brand,speed)
        {
            NumberOfDoors = doors;
            MyEngine = new Engine();
        }
        public void DisplayCar()
        {
            DisplayVehicle();
            Console.WriteLine($"Number Of Doors:{NumberOfDoors}");
            MyEngine.DisplayEngine();
        }
    }
}
