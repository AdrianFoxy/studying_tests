namespace reference_and_value_types
{
    class Program
    {
        // stack и heap это области оперативной памяти, но используются они по разному. 
        // так же различия в целях использования и в обьемах использования оперативной памяти
        // stack - маленький обьекм оперативки для heap - большой

        // stack - обьем оперативки что выделяется для каждого потока.
        // stack - используется для хранения переменных,
        // выполнения операций над ними
        // а так же для вызова методов
        // дефолт значение ограничивается 1МБ
        // тут можно быстро размещать данные и быстро их освобождать
        // принцип стека - last in first out

        // heap - куда более стека
        // много но медленно


        // value types живет в стеке
        // reference types - в куче

        // value type is strcut, enum. For example int - is struct, int - value type
        // reference type - class. Random - reference type

        // value types прекращаю свое существование когда покидают контекст в котором они были определены
        // reference types когда обьек подвергается сборке мусора

        // поведение при передеаче параметров и копировании:
        // value types - переменные передаются по значению (копируются реальные данные)
        // reference types - копируется ссылка, огигинал и копия ссылаются на один и тот же обьект в куче, одни и те же данные

        static void Foo(int a)
        {
            a = 5;
        }

        static void Bar(int[] arr)
        {
            arr[0] = 5;
        }

        static void Main(string[] args)
        {
            // value type
            int a = 5;
            double test = 5;

            // value type
            System.Int32 b = 5;

            // reference type
            Random random = new Random();

            // It writes that is struct, but all arrays is from class Array. So - reference
            int[] arr = new int[10];


            // VALUE TYPES -  int g exists only, until we are in this { }
            {
                int g = 2;
            }

            // REFERENCE TYPE - в h попадает адресс на массив, т.е h это просто ссылка на мой массив
            // если выйти за скобки - удалится ссылка на массив, но память выделенная на массив осталась
            // и она останется пока не сработает сборщик мусора
            {
                int [] h = new int[10];
            }

            // копирование
            int s = 10; // stack
            int k;
            k = s; // stack
            // here we have two differes variables s and k in stack, with their values

            int[] arr2 = new int[10];
            // в стек попадается ссылка на массив arr2(ref) а в кучу arr2(data) данные
            // как пример - arr2 - ярлык на рабочем столе, а данные храняться где-то еще на диске

            int[] arrb = new int[10];
            int[] arrg;
            arrg = arrb;
            // в stack попадают ссылки на оба массива arrb(ref) arrg(ref),
            // в heap только данные изначальные a(data) и оба массива ссылкаются на них

            int fa = 1;
            Foo(fa);
            Console.WriteLine(fa); // 1; because value type

            int[] farr = new int[1];
            farr[0] = 1;
            Bar(farr);
            Console.WriteLine(farr[0]); // 5; because reference type
        }
    }
}