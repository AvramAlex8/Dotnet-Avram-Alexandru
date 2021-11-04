using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> stuff = new List<int>() { 5 };
            int[][] studentGrades = 
            {
                stuff.ToArray(),
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
