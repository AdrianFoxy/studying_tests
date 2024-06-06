namespace reference_and_value_types
{
    class Program
    {
        static void Foo(int a)
        {
            a = 10;
        }

        static void Bar(Vegetable vagetable) 
        {
            vagetable.Name = "Potato";
        }

        class Vegetable
        {
            public Vegetable(string Name, string Home_Farm)
            {
                this.Name = Name;
                this.Home_Farm = Home_Farm;
            }

            public string Name { get; set; }
            public string Home_Farm { get; set; }
        }

        public class MyClass
        {
            public int Value { get; set; }

            public MyClass(int value)
            {
                Value = value;
            }
        }

        // Here is new reference doesn't work
        public static void ModifyObject(MyClass myObject)
        {
            // Change Value
            myObject.Value = 20;
            // Make new reference
            myObject = new MyClass(30);
        }

        // Here is new reference works, because we are using keyword ref
        public static void ModifyObjectRef(ref MyClass myObject)
        {
            // Change Value
            myObject.Value = 20;
            // Make new reference
            myObject = new MyClass(30);
        }

        static void Foo2(ref int a)
        {
            a = 10;
        }

        static void Main(string[] args)
        {
            int a = 5;
            Foo(a);
            Console.WriteLine(a); // 5
                                  // Because int is a value type, in methods we create a copy of a
                                  // and this copy will be alive only using the method.
                                  // Then it dies, but with original a = 5 nothing happens

            Vegetable vag = new Vegetable("Cucumber", "Funny Bob Farm");
            Bar(vag);
            Console.WriteLine(vag.Name); // Potato
                                         // Cucumber will be replaced with Potato, because class is value type
                                         // Because in the methods Bar creates not copy, but reference to the value of this object
                                         // So if it will be changed somewhere, it will be changed everywhere

            Foo2(ref a);
            Console.WriteLine(a); // 10
                                  // int is a value type, but with ref keyword in will be reference
                                  // so in the method, instead  of creating copy, we just use reference to this value


            MyClass obj = new MyClass(10);
            Console.WriteLine("Before modification: " + obj.Value); // Output: 10

            // Sebd object without ref
            ModifyObject(obj);
            Console.WriteLine("After ModifyObject: " + obj.Value); // Output: 20

            // Send object with ref
            // Here creates new reference to reference
            ModifyObjectRef(ref obj);
            Console.WriteLine("After ModifyObjectRef: " + obj.Value); // Output: 30


            // boxing and unboxing
            // object is basic class for all data types in C#

            // we make space in the heap and copy b value there
            // and then get reference to this date in the c 
            // boxing
            int b = 1;
            object c = b;
            // unboxing
            int e = (int)c;

            // unboxing like this will not work, because we were boxing int and can't unbox it to another datatype
            // decimal d = (decimal)c; // InvalidCastException
        }
    }
}