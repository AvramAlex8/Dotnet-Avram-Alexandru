using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.doSomething();
        }
        public void doSomething()
        {
            User user = new User();
            user.FirstName = "Caleb";
            user.LastName = "Curry";
            Console.WriteLine(user.Output());
        }
    }
}
