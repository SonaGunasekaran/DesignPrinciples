using System;

namespace DesignPrinciples.Interface_Segregation_Principle
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Design Principles!");

            ICar car = new Car();
            car.Drive();
            IAirplane  plane = new Airplane();
            plane.Fly();

        }
    }
}
