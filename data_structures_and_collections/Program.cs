using System.Collections;

namespace data_structures_and_collections
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Arrays.
            // Arrays are static in size.
            // Arrays are static in type (all array elements must be of the same type).
            // Array size must be known upon declaration time
            string[] array = { "Hello", "World"};

            // Array good for reading, but bad for add and remove
            // List bad for reading, but good for add and remove

            // Lists | In fact, List is just a wrapper around an array.
            // Lists are dynamic in size.
            // Lists are static in type (all list elements must be of the same type).
            // A list size changes throughout the list's lifecycle         
            List<string> list = new List<string>();

            // For add O(1) - good.
            list.Add("Hello");
            list.Add("World");

            // Cus list is array, for insert it should move everything from index 1 and then insert element to index 1
            // Insert - O(n). More elements - more difficult. Bad.
            list.Insert(1, "Potato");

            // Remove is again O(n), because for remove we should find element by index, remove it and then move elements 

            list.Remove("Potato");
            // But if we will remove last element, it will be easy and it's O(1)
            list.RemoveAt(1);

            // It will be quick sort
            list.Sort();

            // To add array to list
            string[] memes = { "Funny cat", "Funny potato", "Top 10 dogs" };
            list.AddRange(memes);

            foreach (string listItem in list)
            {
                Console.WriteLine(listItem);
            }

            // Array Lists
            // Arrays lists are dynamic in size
            // Arrays lists are dynamic in type (array lists elements can be different different types)
            // An array lists's size changes throughout the array list's lifecycle
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hello");
            arrayList.Add(1);

            // SortedList
            // SortedList are dynamic in size
            // SortedList are static in type
            // SortedList have a key, which is assiciated with a value.
            // SortedList is sorted by key, using IComparer implementation
            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {3, "Three"},
                                        {5, "Five"},
                                        {1, "One"}
                                    };

            Console.WriteLine("---Initial key-values--");

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            numberNames.Add(6, "Six");
            numberNames.Add(2, "Two");
            numberNames.Add(4, "Four");

            Console.WriteLine("---After adding new key-values--");

            foreach (var kvp in numberNames)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);


            // Stacs
            // Stacs are dynamic in size
            // Stacs are dynamic in type (stack elemets can be of different types).
            // A stack's size changes throughout the stack;s lifecycle.
            // C# includes the generic Stack<T> and non-generic Stack collection classes. It is recommended to use the generic Stack<T> collection.
            // FILO. First in, last out.
            Stack stack = new Stack();
            stack.Push("I can add a string"); // First
            stack.Push(1); // Second
            stack.Push(true); // Third

            var last = stack.Pop(); // Removes and returns the last object
            var last5 = stack.Peek(); // method returns the lastly added value from the stack but does not remove it. 

            // QUEUES
            // exactly opposite of the Stack<T> collection
            // Queues are dynamic in size
            // Queues can be dynamic in type (queue elemts can be of diffenent types)
            // A queue's size changes throughout the queue's lifecycle
            // FIFO: First in, first out.
            // C# includes generic Queue<T> and non-generic Queue collection. It is recommended to use the generic Queue<T> collection.
            Queue queue = new Queue(); // Dynamic in type
            Queue<string> queue1 = new Queue<string>(); // Static in type

            queue.Enqueue("I can add a string");
            queue.Enqueue(1);
            queue.Enqueue(true);

            var first = queue.Dequeue(); // Removes and return the first object

            // Linked lists
            // Linked lists are dynamic in size.
            // Linked lists are static in type (linked lists elements must be ob the same type).
            // Linked list's size changes throughout the linked list's lifecycle.
            Console.WriteLine("\n");
            LinkedList<string> my_list = new LinkedList<string>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");

            LinkedListNode<string> node = my_list.Find("Rohan");
            my_list.AddAfter(node, "Potato");

            my_list.Remove(my_list.First); // Remove first
            my_list.Remove("Rohit"); // Remove by value
            my_list.RemoveFirst(); // Remove first
            my_list.RemoveLast(); // Remove last
            // my_list.Clear(); // remove everything

            Console.WriteLine("Best students of XYZ university:");

            // Accessing the elements of 
            // LinkedList Using foreach loop
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }


            // Dictionaries
            // Dictionaries are dynamic in size.
            // Dictionaries are static in type (dictionary elemts must be of the same type)
            // A dictionary's size changes throughout the dictionary's lifecycle.
            // Dictionaries have a key, which is assiciated with a value.
            // KEYS IN DICTIONARIES ARE UNIQ, IN ANOTHER WAY - EXCEPTION.
            Console.WriteLine("\n");
            var cities = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            Console.WriteLine(cities["UK"]);
            cities["UK"] = "Liverpool, Bristol"; // update value of UK key

            // But I will need something like key-value, for example group - student
            // I can combine collection - Dictionary<string, List<string>> groupStudents = new Dictionary<string, List<string>>();
            var groupStudents = new Dictionary<string, List<string>>()
            {
            {"GroupA", new List<string> { "Alice", "Bob", "Grace", "Hank" }},
                {"GroupB", new List<string> { "Charlie", "David" }},
                {"GroupC", new List<string> { "Eve", "Frank" }}
            };

            foreach (var kvp in groupStudents)
            {
                Console.WriteLine($"Group: {kvp.Key}");
                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"  Student: {student}");
                }
            }


            // HASHTABLES
            // Hashtables are dynamic in size.
            // Hashtables are dynamic in type(hashtables elements can be of different type)
            // A hashtable's size changes throughout the hanstable's lifecycle.
            // Hashtable have a key, which is associated with a value

            // The Hashtable collection can include all the elements of Dictionary
            Console.WriteLine("\n");
            var cities2 = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"},
                {true, "Potato, Cucumber" }
            };

            foreach (DictionaryEntry de in cities2)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            var citiesOfUK = cities2["UK"]; //cast to string
            Console.WriteLine(citiesOfUK);


        }
    }
}