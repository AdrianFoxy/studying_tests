namespace what_is_LINQ
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Standart
            int[] numbers = { 5, 10, 8, 3, 6, 12 };

            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            // Extention
            List<string> fruits = new List<string> { "Apple", "Banana", "Mango", "Orange", "Pineapple" };
            var fruitsWithA = fruits.Where(fruit => fruit.Contains("a")).OrderBy(fruit => fruit);

            Console.WriteLine("\nФрукты, содержащие букву 'a':");
            foreach (var fruit in fruitsWithA)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}