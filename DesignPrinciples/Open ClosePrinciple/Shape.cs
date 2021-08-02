using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Open_ClosePrinciple
{
    public abstract class Shape
    {
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public override double Area()
        {
            double area, width = 5,height=5;
            area = width * height;
            return area;
        }
    }

    public class Circle : Shape
    {
        public override double Area()
        {
            double area,radius=5;
            area=radius * radius * Math.PI;
            return area;
        }
    }

}
