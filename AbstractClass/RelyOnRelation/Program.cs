using System;

namespace RelyOnRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            var car = new Car(engine);
            car.Run(3);
            Console.WriteLine(car.Speed);
        }
    }

    class Engine
    {
        public int PRM { get; private set; }
        public void Work(int gas) 
        {
            this.PRM = 1000 * gas;
        }
    }
    class Car 
    {
        private Engine _engine;
        public Car(Engine engine ) 
        {
            _engine = engine;
        }
        public int Speed { get;private set; }
        public void Run(int gas) 
        {
            _engine.Work(gas);
            this.Speed = _engine.PRM/100;
        }
    }
}
