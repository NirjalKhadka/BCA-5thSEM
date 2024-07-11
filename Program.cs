
using classandobject.cars;
using System;

namespace classandobject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Model = "bugatti";
            car1.Color = "Red";
            //car1.number = 224;tnet.run

            car1.start();
            Console.WriteLine("Car Details:");
            car1.details(car1.Model,car1.Color);
            Console.ReadKey();
        }
    }
}
