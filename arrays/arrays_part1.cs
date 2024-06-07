using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public class arrays_part1
    {
        public void ShowPart1()
        {
            // single-dimensional array

            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] array2 = new int[] { 3, 4, 5 };

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + "\t");
            }


            Console.WriteLine("\nReverse single-dimensional array\n");

            for (int i = array1.Length - 1; i >= 0; i--)
            {
                Console.Write(array1[i] + "\t");
            }

            Console.WriteLine("\nSum of multiples of the array\n");

            int sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + "\t");

                if (array2[i] % 2 == 0)
                {
                    sum += array2[i];
                }
            }
            Console.Write($"Sum is {sum}");

            Console.WriteLine("\nMinimal value of array\n");
            int min = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + "\t");
                if (array1[i] < min) min = array1[i];
            }
            Console.Write($"Min is {min}");
        }
    }
}
