namespace exception_handling
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("У доступі відмовлено - вам має бути не менше 18 років.");
            }
            else
            {
                Console.WriteLine("Доступ надано - ти вже дебелий лобуряка!");
            }
        }

        static void Main(string[] args)
        {
            void Foo(int i, string? str)
            {
                if (i == -1 || i == 1)
                {
                    throw new ArgumentException("i equals -1 or 1", nameof(i));
                }
                if (i <= -10 || i >= 10)
                {
                    throw new ArgumentOutOfRangeException(nameof(i));
                }
                if (str is null)
                {
                    throw new ArgumentNullException(nameof(str));
                }
            }
            void Bar(int i, string? str)
            {
                try
                {
                    Foo(i, str);
                }
                catch (ArgumentNullException)
                {
                    Console.Write("2");
                }
                catch (Exception)
                {
                    Console.Write("3");
                }
                finally
                {
                    Console.Write("4");
                }
            }

            Bar(-1, string.Empty);

            /* int[] myNumbers = { 1, 2, 3 };
             Console.WriteLine(myNumbers[10]); // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'*/
            /*checkAge(15);*/

            /*try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Щось пішло не комільфо.");
            }
            finally
            {
                Console.WriteLine("Тепер 'try catch' завершено.");
            }*/


        }
    }
}