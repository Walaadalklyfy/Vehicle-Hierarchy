namespace Vehicle_Hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("TOYOTA", 120, 4);
            Console.WriteLine("=====Car Information======");
            car.DisplayCar();
            Console.WriteLine();
            Bus bus = new Bus("Mercedes", 100, 50);
            Console.WriteLine("===Bus Informtion===");
            bus.DisplayBus();
            Console.WriteLine();
            Vehicle vehicle = new Car("BMW", 150, 4);
            Console.WriteLine("===Vehicle Reference===");
            vehicle.DisplayVehicle();
            
        }
    }
}
