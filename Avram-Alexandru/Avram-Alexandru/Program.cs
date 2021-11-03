using System;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grades = 
            {
                new int[] {5, 4, 7, 3 },
                new int[] {7, 3, 2, 6, 7, 4, 2, 4 },
                new int[] {5, 3, 7, 3 }
            };
            Console.WriteLine(grades[1][6]);
        }
    }
}
