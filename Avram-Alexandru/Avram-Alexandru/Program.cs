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
            User.PrintUser(user);
            User user2 = new User();
            user2.FirstName = "Chocolate";
            List<User> users = new List<User>();
            users.Add(user);
            users.Add(user2);
            User.PrintUsers(users);
        }
    }
}
