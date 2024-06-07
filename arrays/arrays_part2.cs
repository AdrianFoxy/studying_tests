using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public class arrays_part2
    {
        public void ShowPart2()
        {

            int[] myArray = { 123, 543, 43, 23, 2, 5434, 12321, 5, 2, 5432, 54 };

            Console.WriteLine(myArray.Max());
            Console.WriteLine(myArray.Sum());
            Console.WriteLine(myArray.Where(x => x % 2 == 0).Sum());

            int[] result = myArray.Distinct().ToArray();
            int[] result2 = myArray.OrderBy(x => x).ToArray();

            // One nymber < 70
            Array.Find(myArray, x => x < 70);
            // One nymber < 70 from last
            Array.FindLast(myArray, x => x < 70);
            // Find all numbes < 70
            Array.FindAll(myArray, x => x < 70);
            // Find index of element
            // If can't find such number, will return -1
            // If there is few numbers, will return first
            Array.FindIndex(myArray, x => x == 123);
            // Well, just reverse array
            Array.Reverse(myArray);
            // With LINQ
            myArray.Where(i => i < 70).ToArray();
            // If there is no such number - will be exception
            myArray.Where(i => i < 70).First();
            // If there is no such number - will be 0, it means default value for collection (int)
            myArray.Where(i => i < 70).FirstOrDefault();
        }
    }
}
