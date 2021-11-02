using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -5;
            Test(a);
            Console.WriteLine(a);
        }
        static void Test(int x)
        {
            x = 100;
        }
    }
}
