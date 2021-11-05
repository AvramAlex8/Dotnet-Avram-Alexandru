using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avram_Alexandru
{
    class Teacher : User
    {
        public override void HelloToConsole()
        {
            Console.WriteLine("Hi, I'm a teacher, my name is " + FullName);
        }
    }
}
