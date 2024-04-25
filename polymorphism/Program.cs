namespace polymorphism
{
    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Engine brr");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("Car makes brrr");
        }
    }

    class SportCar : Car
    {
        protected override void StartEngine()
        {
            Console.WriteLine("Sport engine brr");
        }
        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("SportCar makes fast brrrrrr");
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Drive(new SportCar());
        }
    }
}
