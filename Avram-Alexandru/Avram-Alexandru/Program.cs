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
            you.FirstName = "John";
            you.LastName = "Smith";
            List<User> users = new List<User>() { me, you };
            User search = new User();
            search.FirstName = "John";
            search.LastName = "Smith";
            Console.WriteLine(User.Find(users, search));
        }
    }
}
