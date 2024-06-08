namespace async_await
{
    class Program
    {
        static void Main(string[] args) 
        {
            SummonDogLocally();
        }

        static async Task SummonDogLocally()
        {
            Console.WriteLine("1. Summoning Dog Locally...");

            string dogText = await File.ReadAllTextAsync("dog.txt");

            Console.WriteLine($"2. Dog Summoned Localy \n{dogText}");
        }
    }
}