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
            Console.WriteLine(me.GetHashCode());
            User you = new User();
            you.FirstName = "Caleb";
            you.LastName = "Curry";
            Console.WriteLine(you.GetHashCode());
            List<User> users = new List<User>() { me, you };
            User search = new User();
            search.FirstName = "John";
            search.LastName = "Smith";
            Console.WriteLine(User.Find(users, search));
            Console.WriteLine(me.GetHashCode() == you.GetHashCode());
        }
    }
}
