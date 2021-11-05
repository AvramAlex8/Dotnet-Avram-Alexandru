using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avram_Alexandru
{
    class User
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value.ToLower();
            }
        }
        public string LastName
        {
            get;
            set;
        }
        public string Output(int times)
        {
            string message = "";
            for (int i = 0; i < times; i++)
            {
                message += FirstName + " " + LastName + "\n";
            }
            return message;
        }
    }
}
