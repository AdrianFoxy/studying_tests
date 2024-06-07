namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // single-dimensional array
            Console.WriteLine("Part1\n");
            new arrays_part1().ShowPart1();
            Console.WriteLine("\nPart2\n");
            new arrays_part2().ShowPart2();
            Console.WriteLine("\nPart3\n");
            new array_indices_ranges_part3().ShowPart3();

            //  two-dimensional array.
            new arrays_part5().ShowPart5();

            Console.WriteLine("\n");

            // jagged array
            int[][] myArray = new int[3][];
            myArray[0] = new int[4];
            myArray[1] = new int[2];
            myArray[2] = new int[8];

            myArray[0][3] = 55;

            Random random = new Random();

            for(int i = 0; i< myArray.Length; i++)
            {
                for(int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}