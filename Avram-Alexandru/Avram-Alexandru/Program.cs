using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            int name = 5;
            switch (name)
            {
                case 3:
                case 5:
                    Console.WriteLine("Get the heck away.");
                    return;
                default:
                    Console.WriteLine("Who are you?");
                    break;
            }
            Console.WriteLine("Welcome!");
        }
    }
}
