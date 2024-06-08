namespace delegates
{
    class Program
    {
        // Singlecast delegates
        public delegate void NoParameters();

        private delegate string WithParameters(string name1, string name2);

        // Multicast delegates
        public delegate void NoParamets2();

        // Anonymous
        // and
        // Delegate as Parameters
        public delegate void NoParamets3();

        static void Main(string[] args)
        {
            // Singlecast delegates
            NoParameters noPrm = new(ShowMessage);
            noPrm();

            WithParameters withPrm = new(ShowMessage);
            string value = withPrm("Bob", "Potato");
            Console.WriteLine($"{value}\n\n");
        
            // Multicast delegates
            NoParamets2 noPrm2 = new(ShowMessage1); // Singlecast
            noPrm2 += ShowMessage2; // Multicast
            // Btw, with += we added method, but for example with -= we can delete it
            noPrm2();

            Console.WriteLine($"\n\n");

            // Anonymous
            NoParamets3 noPrm3 = delegate ()
            {
                Console.WriteLine($"Have fun!");
            };

            noPrm3();
            Console.WriteLine($"\n\n");

            // Delegate as Parameters
            Test(noPrm3);

            Console.ReadKey();
        }

        private static void Test(NoParamets3 noPrm) => noPrm();
        private static void ShowMessage1() => Console.WriteLine($"Have fun!");
        private static void ShowMessage2() => Console.WriteLine($"See you!");

        private static string ShowMessage(string name1, string name2)
        {
            Console.WriteLine($"{name1}, {name2} Have fun!");
            return "with this beautiful life :)";
        }
        private static void ShowMessage() => Console.WriteLine("Have fun!");
    }
}