namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 5;

            Console.WriteLine($"a = {a}\t b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {a}\t b = {b}");

            Console.WriteLine();

            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine($"a = {str1}\t b = {str2}");
            Swap(ref str1, ref str2);
            Console.WriteLine($"a = {str1}\t b = {str2}");

            int result = Foo<int>();
            Console.WriteLine();

            MyList<int> myList = new MyList<int>();
            myList.Add(7);
            myList.Add(4);
            myList.Add(8);
            myList.Add(4);

            for(int i = 0; i < myList.Count; i++) 
            {
                Console.WriteLine(myList[i]);
            }
        }

        static void Swap<T>(ref T a, ref T b) 
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void SwapByObject(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }

        static T Foo<T>()
        {
            // will return default value for current datatype
            // for example int = 0
            // string = null
            // etc
            return default(T);
        }
    }
}