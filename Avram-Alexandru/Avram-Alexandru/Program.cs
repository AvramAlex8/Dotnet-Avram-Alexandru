using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] grades = new int[size];
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"{ grades[i] } ");
            }
        }
    }
}
