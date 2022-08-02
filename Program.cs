using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class student
    {
        public string strName;
        public string strCourse;
        public string strGroup;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student obj1, obj2; // dealaring two object names of type student
            obj1 = new student(); //instantatie obj1
            obj2 = new student();
            Console.Write("Enter the name for student 1: ");
            obj1.strName = Console.ReadLine();
            Console.Write("Enter the course for student 1: ");
            obj1.strCourse = Console.ReadLine();
            Console.Write("Enter the group name for student 1: ");
            obj1.strGroup = Console.ReadLine();
            Console.Write("Enter the")


        }
    }
     
    
}
