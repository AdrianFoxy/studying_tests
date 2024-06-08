namespace lambda
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { Name = "John", Age = 25},
                new Person { Name = "Potato man", Age = 32},
                new Person { Name = "Bruh mem", Age = 19}
            };
        }
    }
}