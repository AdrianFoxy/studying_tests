using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyword_partial
{
    partial class Person
    {
        public partial string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
