namespace upcast_downcast
{
    class Vehicle 
    {
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving");
        }
    }
    class Car : Vehicle 
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            // Upcast
            Vehicle vehicle = new Car();
            vehicle.Drive(); // Должно вывести "Car is driving" благодаря полиморфизму

            // Downcast с проверкой
            Vehicle vehicle2 = new Car();
            if (vehicle2 is Car)
            {
                Car car = vehicle2 as Car;
                car.Drive(); // Должно вывести "Car is driving"
            }
            else
            {
                Console.WriteLine("vehicle2 is not a Car");
            }
        }

    }
}