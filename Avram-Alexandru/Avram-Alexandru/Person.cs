using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avram_Alexandru
{
    public class Person
    {
        string middleName = "Granola Bar";
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        
    }
}
