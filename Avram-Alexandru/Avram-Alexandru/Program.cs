using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What's the password?");
            string password = Console.ReadLine();
            if(!(age <= 12) || password != "password123")
            {
                Console.WriteLine("Welcome! You're atleast a teenager and got correct password.");
            }
        }
    }
}
