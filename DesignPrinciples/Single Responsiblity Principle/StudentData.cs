using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPrinciples.Single_Responsiblity_Principle
{
    class StudentData
    {
        List<Student> list = new List<Student>();
        Student st = new Student();
        public List<Student> ReadInput()
        {
            Console.WriteLine("Enter Student Name:");
            st.StudentName = Console.ReadLine();
            Console.WriteLine("Enter Student Id:");
            st.StudentId = Convert.ToInt32(Console.ReadLine());
            list.Add(st);
            return list;
        }
    }
}
