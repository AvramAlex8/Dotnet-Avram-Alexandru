using System;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Caleb";
            person.LastName = "Curry";
            Console.WriteLine("What do you think the name is?");
            string fullNameGuess = Console.ReadLine();
            if(person.FullName == fullNameGuess)
            {
                Console.WriteLine("You got the name! You win!");
            }
            else
            {
                Console.WriteLine("Second guess?");
                fullNameGuess = Console.ReadLine();
                if(person.FullName == fullNameGuess)
                {
                    Console.WriteLine("You got the name! You get 0.5 points!");
                }
                else
                {
                    Console.WriteLine("You're a dissapointment!");
                }
            }
        }
    }
}
