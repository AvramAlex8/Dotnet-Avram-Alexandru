using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] studentGrades = 
            {
                new int[]{ 5, 10, 26 },
                new int[]{ 34, 26, 26 },
                new int[]{ 26, 2, 23, 26, 200}
            };
            foreach (int[] grades in studentGrades)
            {
                foreach (int grade in grades)
                {
                    Console.Write($"{ grade }\t");
                }
                Console.WriteLine();
            }
        }
    }
}
