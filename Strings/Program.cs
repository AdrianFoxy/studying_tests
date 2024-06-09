namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = new String('a', 6);
            string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3);

            Console.WriteLine(s1);  // hello
            Console.WriteLine(s2);  // aaaaaaa
            Console.WriteLine(s3);  // world
            Console.WriteLine(s4);  // orl

            Console.WriteLine("\n");

            string message = "hello";

            for (var i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
            foreach (var ch in message)
            {
                Console.WriteLine(ch);
            }

            Console.WriteLine("\n");

            string message1 = "hello";
            string message2 = "hello";

            Console.WriteLine(message1 == message2);    // true
        }
    }
}