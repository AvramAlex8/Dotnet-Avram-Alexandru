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
            List<string> firstNames = new List<string>() { "Caleb", "John", "Sub" };
            List<string> lastNames = new List<string>() { "Curry", "Athon", "Scriber" };
            List<User> users = new List<User>();
            for (int i = 0; i < firstNames.Count; i++)
            {
                User user = new User();
                user.FirstName = firstNames[i];
                user.LastName = lastNames[i];
                users.Add(user);
            }
            for (int i = 0; i < users.Count; i++)
            {
                takeUser(users[i]);
            }
        }
        public void takeUser(User user)
        {
            Console.WriteLine(user.FullName);
        }
    }
}
