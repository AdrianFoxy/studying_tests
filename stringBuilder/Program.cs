using System.Text;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello world");

            Console.WriteLine($"Length: {sb.Length}");       // 11
            Console.WriteLine($"Capacity: {sb.Capacity}");   // 16

            Console.WriteLine(sb.ToString());    //  Hello World
            Console.WriteLine($"{sb}\n");

            var sb2 = new StringBuilder("Hello world", 32);

            Console.WriteLine($"Length: {sb2.Length}");       // 11
            Console.WriteLine($"Capacity: {sb2.Capacity}");   // 32

            sb2.Append(" and You!");
            Console.WriteLine($"{sb2}\n");

            Console.WriteLine($"Length: {sb2.Length}");       // 11
            Console.WriteLine($"Capacity: {sb2.Capacity}");   // 32

            sb2.Append(" and Me!");
            sb2.Append(" and He and She!");

            Console.WriteLine($"{sb2}\n");

            Console.WriteLine($"Length: {sb2.Length}");       // 44
            Console.WriteLine($"Capacity: {sb2.Capacity}");   // 64

            sb2.Insert(7, "potato ");
            sb.Replace("Me", "King");
            sb.Remove(5, 3);
            string text = sb2.ToString();
            Console.WriteLine($"{text}\n");






        }
    }
}