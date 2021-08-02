using System;

namespace DesignPrinciples.Liskov_substitution_principle
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Design Principles!");

            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }
}
