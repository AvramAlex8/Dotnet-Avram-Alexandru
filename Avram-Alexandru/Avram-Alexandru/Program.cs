using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[10];
            grades[4] = 10;
            Console.WriteLine(grades[4]);
            Console.WriteLine(grades.Length);
        }
    }
}
