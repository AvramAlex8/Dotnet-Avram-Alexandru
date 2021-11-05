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
            User me = new User();
            me.FirstName = "Caleb";
            me.LastName = "Curry";
            User you = new User();
            you.FirstName = "Caleb";
            you.LastName = "Curry";
            Console.WriteLine(me.Equals(you));
        }
    }
}
