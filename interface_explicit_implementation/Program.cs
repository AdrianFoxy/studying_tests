namespace interface_explicit_implementation
{
    interface IFirstInterface
    {
        void Action();
    }

    interface ISecondInterface
    { 
        void Action(); 
    }

    class MyClass : IFirstInterface, ISecondInterface
    {
        public void Action()
        {
            Console.WriteLine("My class action...");
        }
    }

    class MyOtherClass : IFirstInterface, ISecondInterface
    {
        void IFirstInterface.Action()
        {
            Console.WriteLine("My class action first interface");
        }

        void ISecondInterface.Action()
        {
            Console.WriteLine("My class action second interface");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Foo(myClass);
            Bar(myClass);

            Console.WriteLine();

            MyOtherClass myOtherClass = new MyOtherClass();
            Foo(myOtherClass);
            Bar(myOtherClass);

            Console.WriteLine();

            IFirstInterface myFirstInterface = myOtherClass;
            myFirstInterface.Action();

            Console.WriteLine();

            ((IFirstInterface)myOtherClass).Action();
            ((ISecondInterface)myOtherClass).Action();

            Console.WriteLine();

            if(myOtherClass is IFirstInterface firstInterface)
            {
                firstInterface.Action();
            }

        }
        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }

        static void Bar(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }
    }
}