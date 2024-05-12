namespace keyword_partial
{
    class Program
    {
        // Partial classes can be razneseni to different files
        static void Main(string[] args)
        {
            Person person = new Person("Bob", "Mils");
            person.PrintFullName();
        }
    }
}