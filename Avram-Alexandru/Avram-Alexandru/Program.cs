using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 30, 430, 23, 10 };
            Array.Sort(grades);
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"{ grades[i] } ");
            }
        }
    }
}
