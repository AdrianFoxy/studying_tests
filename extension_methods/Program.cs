namespace extension_methods 
{

    class Program
    {
        static void Main(string[] args)
        {
            // Extentions works only in the same namespace
            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();

            DateTime.Now.Print();

            Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Saturday));

            Student student = new Student() { FirstName = "Bob", LastName = "Leboske" };
            string fullName = student.GetFullName();
            Console.WriteLine(fullName);
        }
    }
}
