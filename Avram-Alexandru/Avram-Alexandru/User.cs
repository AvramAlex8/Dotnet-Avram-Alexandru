using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avram_Alexandru
{
    class User
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public void Output(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(FirstName);
                Console.WriteLine(LastName);
            }
        }
    }
}
