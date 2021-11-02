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
            Console.WriteLine(person.FullName);
        }
    }
}
