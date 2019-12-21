using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Car();
            vehicle.Run();
        }

    }

    interface IVehicle
    {
        void Stop();
        
        void Run();
    }

    abstract class Vehicle: IVehicle
    {
        public abstract void Run();

        public abstract void Stop();
       
    }

    class Car: IVehicle
    {
        public  void Run() 
        {
            Console.WriteLine("Car is Running");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }
    class Truck : IVehicle
    {
        public  void Run()
        {
            Console.WriteLine("Truck is Running");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }

    class RaceCar : IVehicle
    {
        public  void Run()
        {
            Console.WriteLine("RaceCar is Running");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
    }
}
