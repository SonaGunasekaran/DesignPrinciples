using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Single_Responsiblity_Principle
{
    class ReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="st"></param>
        public void GenerateEmployeeReport(List<Student> st)
        {
            foreach (var l in st)
            {
                Console.WriteLine("Employee Name:" + l.StudentName);
                Console.WriteLine("Employee Id:" + l.StudentId);
            }
        }
    }
}
