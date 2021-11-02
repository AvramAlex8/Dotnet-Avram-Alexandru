using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Math.Pow(999, 99999999);
            Console.WriteLine(double.IsInfinity(a));
        }
    }
}
