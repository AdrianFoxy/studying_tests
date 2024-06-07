using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public class array_indices_ranges_part3
    {
        public void ShowPart3()
        {
            // indices and ranges
            // ^1 means that we want to get element from last
            int[] myArray = { 2, 10, 5, 77, 99, 54 };
            Console.WriteLine(myArray[^1]);

            Index myIndex = ^1;
            Console.WriteLine(myArray[^1]);

            // range n..b
            // from n to b
            int[] myArray2 = myArray[1..4];
            int[] myArray3 = myArray[..4];
            int[] myArray4 = myArray[2..];

            string str = "Hello world! :)";
            Console.WriteLine(str[^2..]);
        }
    }
}
