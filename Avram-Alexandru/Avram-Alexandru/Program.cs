using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>() { 5, 10 };
            grades.Add(30);
            grades.Insert(2, 15);
            grades.Remove(10);
            Console.WriteLine(grades[0]);
            Console.WriteLine(grades[1]);
            Console.WriteLine(grades[2]);
        }
    }
}
