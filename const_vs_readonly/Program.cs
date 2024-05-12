using System;

namespace const_vs_readonly
{
    class MyClass
    {
        // const valie cannot be changed
        // after creating const field, ALWAYS need some value
        // it mean public const int a; - will not work
        // public const int a = 5; yes

        // const field is static field
        private const int a = 5;

        public const double PI = 3.14;

        public const string MY_ERROR = "some error";

        // readonly can be initialised later
        // readonly is not static MyClass.b - will not work, until you will add static to the field
        // readinly can be initialised ONLY after creting or in constructor
        public readonly int _b;
        public readonly int _c = 2;

        public static readonly int _d;

        static MyClass()
        {
            _d = 0;
        }

        public MyClass(int b)
        {
            _b = b;
        }

        public static void Foo()
        {
            Console.WriteLine(a);
            Console.WriteLine(PI);
            Console.WriteLine(MY_ERROR);
            Console.WriteLine(_d);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyClass.PI);
            MyClass myClass = new MyClass(2);
            Console.WriteLine(myClass._b);
        }
    }

}