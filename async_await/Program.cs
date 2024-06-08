using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace async_await
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*await SummonDog1();
            await SummonDog2();*/

            Stopwatch sw = new Stopwatch();
            sw.Start();

            var tasks = new List<Task> { SummonDog1(), SummonDog2() };
            await Task.WhenAll(tasks);

            sw.Stop();
            Console.WriteLine("We are done here " + sw.Elapsed.TotalSeconds);
        }

        static async Task SummonDog1()
        {
            Console.WriteLine("1. Summoning Dog1...");
            string dogText = await File.ReadAllTextAsync("dog.txt");

            await Task.Delay(1000);

            Console.WriteLine($"Here is our doggo number 1: \n" + dogText);
        }

        static async Task SummonDog2()
        {
            Console.WriteLine("2. Summoning Dog1...");
            string dogText = await File.ReadAllTextAsync("dog2.txt");

            Console.WriteLine($"Here is our doggo number 2: \n" + dogText);
        }
    }
}
