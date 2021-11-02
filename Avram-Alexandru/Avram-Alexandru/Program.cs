using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "hello my name is Caleb!";
            string[] words = name.Split(" ");
            Console.WriteLine(words[1]);
        }
    }
}
