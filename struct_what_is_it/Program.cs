using System.Collections;

namespace struct_what_is_it
{
    public class ClassPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    public struct StructPoint
    {
        public StructPoint(int X) 
        {
            this.X = X;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public void Print()
        {
            Console.WriteLine($"X:{X}\tY:{Y}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassPoint classPoint = new ClassPoint { X = 2, Y = 3};
            ClassPoint classPoint1 = new ClassPoint { X = 2, Y = 3 };

            bool classesAreEqual = classPoint.Equals( classPoint1 );

            StructPoint p2 = new StructPoint { X = 2, Y = 3 };
            StructPoint p = new StructPoint { X = 2, Y = 3 };

            bool strcutsAreEqual = p2.Equals(p);

            Console.WriteLine(classesAreEqual);
            Console.WriteLine(strcutsAreEqual);


        }
    }
}