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
            me.Verified = true;
            Console.WriteLine(me.FullName);
        }
    }
}
