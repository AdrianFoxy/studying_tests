namespace ref_keyword
{
    class Program
    {
        // ref means, that a with be by reference, so a = -5
        // значит передаем параметр по ссылке, а не значению как было
        static void Foo(ref int a)
        {
            a = -5;
        }

        struct MyStruct
        {
            public int a;
            public double b;
            public float c;
        }

        class MyClass
        {
            public int a;
            public double b;
            public float c;
        }

        static void Foo2(ref MyStruct myStruct)
        {
            myStruct.a = -5;
        }

        static void Foo3(MyClass myClass)
        {
            myClass.a = -5;
        }

        static void Bar(ref int[] arr)
        {
            arr = null;
        }

        static ref int Foo4(int[] numbers)
        {
            return ref numbers[0];
        }

        static void Main(string[] args)
        {
            int a = 2;
            Foo(ref a);
            Console.WriteLine(a);

            MyStruct myStruct = new MyStruct();
            Foo2(ref myStruct);

            int[] myArray = { 1, 4, 6 };
            Bar(ref myArray);

            int[] arr = {2 , 6 , 7 };
            ref int b = ref arr[0];
            b = -5;

            int[] arr2 = { 2, 6, 7 };
        }
    }
}