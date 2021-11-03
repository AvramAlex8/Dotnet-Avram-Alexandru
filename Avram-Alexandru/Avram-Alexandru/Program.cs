using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            bool logging = false;
            for (int i = 9; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
                if(i == 7)
                {
                    if(logging == true)
                    {
                        Console.WriteLine("We found 7!");
                    }
                }
            }
        }
    }
}
