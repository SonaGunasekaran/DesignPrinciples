using System;

namespace DesignPrinciples.Single_Responsiblity_Principle
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Design Principles!");
            
            StudentData st = new StudentData();
            st.ReadInput();
            
            ReportGeneration report = new ReportGeneration();
            
        }
    }
}
