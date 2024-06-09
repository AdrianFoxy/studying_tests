namespace as_and_is
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = "Hello, world!";
            if (obj is string)
            {
                Console.WriteLine("obj is a string");
            }
            else
            {
                Console.WriteLine("obj is not a string");
            }

            if (obj is string str)
            {
                Console.WriteLine($"obj is a string: {str}");
            }
            else
            {
                Console.WriteLine("obj is not a string");
            }

            object obj2 = "Hello, world!";
            string str2 = obj2 as string;

            if (str2 != null)
            {
                Console.WriteLine($"obj was successfully cast to string: {str2}");
            }
            else
            {
                Console.WriteLine("obj could not be cast to string");
            }



        }
    }
}