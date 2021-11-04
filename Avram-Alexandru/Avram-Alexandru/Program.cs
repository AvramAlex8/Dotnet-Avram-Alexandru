using System;
using System.Collections.Generic;
using System.Linq;

namespace Avram_Alexandru
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person();
            me.Name = "Caleb";
            Console.WriteLine(me.Talk());
        }
    }
}
