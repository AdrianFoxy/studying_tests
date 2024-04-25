namespace tests_after_test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*bool Foo(bool x, bool y, bool z) => x | (y ^ !z); // true*/
            /*bool Foo(bool x, bool y, bool z) => x | (!y & !z); // true*/
            /*bool Foo(bool x, bool y, bool z) => !x & (y | !z); // false*/
            /*bool Foo(bool x, bool y, bool z) => x & (!y ^ !z); */// true
            /*bool Foo(bool x, bool y, bool z) => !x | (!y & z); // false*/
            // Console.WriteLine(Foo(true, false, false));

            /*void Foo(int i, string? str)
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

            Bar(-1, string.Empty);*/

            // 0, string.Empty is 4
            // 1, string.Empty is 34
            // -10, string.Empty is 34
            // -1, string.Empty is 34
            // 0 string.Empty is 4

            /*int i = 0;
            i++;
            i = i + i++;
            Console.WriteLine(i);*/


            string test1 = "\\\"Joe\"\\";
            string test2 = @"\""Joe""\";
            Console.WriteLine(test1);

            /*string[] source = new string[]
            {
                "jan", "feb", "mar", "apr", "may", "jun",
                "jul", "aug", "sep", "oct", "nov", "dec"
            };

            string[] dest = new string[6];
            Array.Reverse(source);
            Array.Copy(source, dest, 6);

            Console.WriteLine(Array.LastIndexOf(dest, "sep"));*/
            // Array.LastIndexOf(dest, "jul") == 6 - false
            // Array.LastIndexOf(dest, "sep") == 3 - true
            // Array.IndexOf(dest, "dec") == -1 - false
            // Array.IndexOf(dest, "jan") == -1 - true
            // Array.IndexOf(dest, "may") == 4 - false
            // if cannot find - it will be -1
        }
    }

}
