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
            Student me = new Student();
            me.FirstName = "Jingle";
            Teacher you = new Teacher();
            you.FirstName = "Sally";
            List<User> users = new List<User>() { me, you };
            foreach (User user in users)
            {
                user.HelloToConsole();
            }
        }
    }
}
