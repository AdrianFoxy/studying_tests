using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    public class arrays_part5
    {
        public void ShowPart5()
        {
            // 1 , - dvyxmerni array
            // 2 , - trexmerni array etc
            int[,] myArray = new int[3, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };

            int[,] myArray2 = new int[,]
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };

            int[,] myArray3 =
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };

            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n");


            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
