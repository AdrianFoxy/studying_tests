namespace dispose_finalize
{
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;

        ~Person()
        {
            Console.WriteLine($"{Name} has deleted");
        }
    }

    public class Person2 : IDisposable
    {
        public string Name { get; }
        public Person2(string name) => Name = name;

        public void Dispose()
        {
            Console.WriteLine($"{Name} has been disposed");
        }
    }

    public class Person3 : IDisposable
    {
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    class Program
    {
        static void Test2()
        {
            Person2? tom = null;
            try
            {
                tom = new Person2("Tom");
            }
            finally
            {
                tom?.Dispose();
            }
        }

        static void Test()
        {
            Person tom = new Person("Tom");
        }

        static void Main(string[] args)
        {
            Test();
            GC.Collect();
            Console.Read();

            Test2();
        }
    }
}

