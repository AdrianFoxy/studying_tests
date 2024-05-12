using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyword_partial
{
    partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firtsName, string lastName)
        {
            FirstName = firtsName;
            LastName = lastName;
        }

        public partial string GetFullName();
    }
}
