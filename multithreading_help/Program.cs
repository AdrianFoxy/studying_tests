namespace multithreading_help
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Run(() => DoWork("Task 1"));
            Task task2 = Task.Run(() => DoWork("Task 2"));

            Console.WriteLine("Main method completed.");

            Task.WaitAll(task1, task2);

            Console.WriteLine("Both tasks completed.");

        }

        static void DoWork(string taskName)
        {
            Console.WriteLine($"{taskName} started.");
            Task.Delay(2000).Wait();
            Console.WriteLine($"{taskName} completed.");
        }

    }
}
