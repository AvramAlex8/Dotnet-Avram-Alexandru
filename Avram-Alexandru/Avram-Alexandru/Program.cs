using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Caleb";
            char[] characters = { 'H', 'e', 'l', 'l', 'o' };
            string greeting = new string(characters);
            Console.WriteLine(greeting);
            string message = $"Hello, my name is {name} and I like to say {greeting}";
            Console.WriteLine(message);
        }
    }
}
