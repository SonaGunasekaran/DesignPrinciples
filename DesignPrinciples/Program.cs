using System;

namespace DesignPrinciples.Open_ClosePrinciple
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Design Principles!");

            double area;
            Rectangle rect = new Rectangle();
            area = rect.Area();
            Console.WriteLine(" Area = "+area);
            Circle c = new Circle();
            area = c.Area();
            Console.WriteLine(" Area = "+area);
        }
    }
}
