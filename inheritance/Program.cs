namespace inheritance
{

    // Part 1
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        {

        }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }


        public void PrintName()
        {
            Console.WriteLine($"My name is {FirstName}");
        }
    }

    class Student : Person
    {
        public void Learn()
        {
            Console.WriteLine("I'm learning now!");
        }
    }

    // Part 2
    class Point2D
    { 
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Here is Point2D constructor");
        }
        public int X { get; set; }
        public int Y { get; set; }


        public void Print2D()
        {
            Console.WriteLine("X:\t" + X);
            Console.WriteLine("Y:\t" + Y);
        }
    }

    class Point3D : Point2D
    {
        public Point3D(int x, int y, int z): base (x, y)
        {
            Z = z;
            Console.WriteLine("Here is Point3D constructor");
        }

        public int Z { get; set; }

        public void Print3D()
        {
            base.Print2D();
            Console.WriteLine("Z:\t" + Y);
        }
    }

    // Part 3
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.WriteLine("X:\t" + X);
            Console.WriteLine("Y:\t" + Y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            /* Person person = new Person { FirstName = "Bob", LastName = "Bobov" };
             person.PrintName();

             Student student = new Student { FirstName = "Student Bob", LastName = "Bobov" };
             student.PrintName();
             student.Learn();

             Person person1 = new Student { FirstName = "Bob", LastName = "Bobov" };
             person1.PrintName();*/

            // Part 2
            /*Point3D point3d = new Point3D(1,2,3);
            point3d.Print3D();*/

            // Part3
            /*            object obj = new Point { X = 3, Y = 5 };
                        Point point = (Point)obj;
                        point.Print();*/

            // Bad example:
            /*            object obj1 = "hello world";
                        Point point1 = (Point)obj1;
                        point1.Print();*/

            object obj = new Point { X = 3, Y = 5 };
            Foo(obj);

        }

        static void Foo(object obj)
        {
            // as - if there is obj really point it will work, in other case, it will be null
            Point point= obj as Point;
            if(point != null)
            {
                point.Print();
            }
        }

        static void Bar(object obj)
        {
            /*if(obj is Point)
            {
                Point point = (Point)obj;
                point.Print();
            }*/
            if (obj is Point point)
            {
                point.Print();
            }
        }
    }
}