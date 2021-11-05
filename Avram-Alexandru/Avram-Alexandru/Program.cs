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
            you.FirstName = "Sub";
            you.LastName = "Scriber";
            List<User> users = new List<User>();
            users.Add(me);
            users.Add(you);
            foreach (User user in users)
            {
                Console.WriteLine(user.FullName);
            }
        }
    }
}
