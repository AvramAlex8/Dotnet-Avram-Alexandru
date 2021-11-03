using System;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades1 = { 30, 430, 23, 10 };
            int[] grades2 = grades1;
            if (grades1 == grades2)
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
