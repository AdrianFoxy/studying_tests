namespace keyword_static
{
    class Program
    {
        class MyClass
        {
            public int a;

            private static int b;
            private static int c;

            public void SetB(int b)
            {
                MyClass.b = b;
                // can't use this.b = b; because for b don't need class object, only class.
                // Because there is possible situation when we stiil don't have class object
            }

            public void PrintB()
            {
                Console.WriteLine(b);
            }


            // Static method can't use not static fields/methods
            // With static can't use classic polymorphism
            public static void Foo()
            {
                Console.WriteLine("Foo");
                c = 5;
                Console.WriteLine(c);
            }

            public void Bar()
            {
                Console.WriteLine("Bar");
                Foo();
            }


            private static int g;

            public static int G
            {
                get { return g; }
                set { g = value; }
            }

            public static int MyProperty { get; set; }

        }

        class CounterClass
        {
            // cosntr can use static fileds and methods
            public CounterClass()
            {
                counter++;
                // Counter++;
            }
            private static int counter;

            public static int Counter
            {
                get { return counter; }
                private set { counter = value; }
            }

            public int ObjectsCounter
            {
                get { return counter; }
            }

            public static int GetCounter()
            {
                return counter;
            }

            public int GetObjectsCounter()
            {
                return counter;
            }

        }

        // Part 3
        class MyClass2
        {
            public MyClass2()
            {
                Console.WriteLine("Constructor");
            }

            // Can't use access modificator for static constructor. public, private, etc - error
            // Can't use reload for static constructor
            // Static constructor can be only ONE and CAN'T get parametrs!
            // Static constructor ALWAYS will be called before normal one
            // Still can't use not static field, methods, because we need class object for it. So a = 5, Bar() and etc - will not work

            static MyClass2()
            {
                Console.WriteLine("Static constructor");
            }

            public static void Foo() 
            {
                Console.WriteLine("Foo");
            }

        }

        class DbRepository
        {
            private static string connectionString;

            static DbRepository()
            {
                ConfigurationManager configurationManager = new ConfigurationManager();
                connectionString = configurationManager.GetConnectionString();
            }
            public void GetData()
            {
                Console.WriteLine("Using: " + connectionString);
            }
        }

        class ConfigurationManager
        {
            public string GetConnectionString()
            {
                return "local DB";
            }
        }

        // Part 4
        // Here is can be ONLY static fields, methods, const etc
        // GOOD EXAMPLE of static class, is Math. Class that united logical united methods by math
        // static classes can't use interface realisation and inheritance
        static class MyClass3
        {
            static MyClass3()
            {

            }
            public static void Foo()
            {
                Console.WriteLine("Foo");
            }
        }

        static void Main(string[] args)
        {
            // Part 1
            // Don't need class object for static field, just class
            //MyClass.b = 5;

            MyClass myClass1 = new MyClass();
            myClass1.SetB(2); // set 2

            MyClass myClass2 = new MyClass();
            myClass2.PrintB(); // print 2

            // Part 2
            // Still can't use static method for class object. myClass.Foo() - doen't work
            // Only MyClass.Foo()
            MyClass myClass = new MyClass();
            myClass.Bar();
            MyClass.Foo();

            MyClass.G = 3;
            MyClass.MyProperty = 4;

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            CounterClass counterClass1 = new CounterClass();
            CounterClass counterClass2 = new CounterClass();

            Console.WriteLine(counterClass2.GetObjectsCounter()); // 2

            CounterClass counterClass3 = new CounterClass();

            Console.WriteLine(CounterClass.Counter); // 3
            Console.WriteLine(CounterClass.GetCounter()); // 3

            // Part 3
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            MyClass2 myClass21 = new MyClass2();
            new MyClass2();
            new MyClass2();
            new MyClass2();
            MyClass2.Foo(); // If it's first call - will call static constructor

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            DbRepository dbRepository = new DbRepository();
            dbRepository.GetData();

            // Part 4
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            // Can't create static class object. MyClass3 test = new MyClass3(); - error; because we cannot create static class object
            MyClass3.Foo();

            

        }
    }
}