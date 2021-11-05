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
            User user2 = new User();
            user2.FirstName = "Chip";
            User user3 = new User();
            user3.FirstName = "Bond";
            List<User> users = new List<User>() { user, user2, user3 };
            Console.WriteLine(User.Find(users, "Chip    "));
        }
    }
}
