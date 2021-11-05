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
            Student me = new Student("Jingle", "Gyro");
            me.HelloToConsole();
            ITalk you = new Student("first", "last");
            
        }
    }
}
