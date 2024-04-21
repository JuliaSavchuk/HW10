namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n_____Task 1_____\n");
            string x = "hello";
            string y = "world";
            Console.WriteLine($"Before swap: x = {x}, y = {y}");
            Task1.SwapValue(ref x, ref y);
            Console.WriteLine($"After swap: x = {x}, y = {y}");

            Console.WriteLine("\n_____Task 2_____\n");
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>((x, y) => x.CompareTo(y));

            priorityQueue.Enqueue(10);
            priorityQueue.Enqueue(30);
            priorityQueue.Enqueue(20);
            priorityQueue.Enqueue(5);

            Console.WriteLine("Count: " + priorityQueue.Count);
            Console.WriteLine("Peek: " + priorityQueue.Peek());

            Console.WriteLine("Dequeue: " + priorityQueue.Dequeue());
            Console.WriteLine("Dequeue: " + priorityQueue.Dequeue());
            Console.WriteLine("Dequeue: " + priorityQueue.Dequeue());
            Console.WriteLine("Count: " + priorityQueue.Count);


            Console.WriteLine("\n_____Task 3_____\n");
            CircularQueue<string> circularQueue = new CircularQueue<string>(3);

            circularQueue.Enqueue("First");
            circularQueue.Enqueue("Second");
            circularQueue.Enqueue("Third");

            Console.WriteLine("Count: " + circularQueue.Count);
            Console.WriteLine("Peek: " + circularQueue.Peek());

            Console.WriteLine("Dequeue: " + circularQueue.Dequeue());
            Console.WriteLine("Dequeue: " + circularQueue.Dequeue());
            Console.WriteLine("Count: " + circularQueue.Count);

            Console.WriteLine("\n_____Task 4_____\n");
            LinkedList<int> list1 = new LinkedList<int>();

            list1.AddLast(1);
            list1.AddLast(2);
            list1.AddLast(3);

            list1.Print(); 

            list1.RemoveFirst();
            list1.Print();


        Console.WriteLine("\n_____Task 5_____\n");
            DoublyLinkedList<int> list2 = new DoublyLinkedList<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            Console.WriteLine("Count: " + list2.Count);

            list2.Remove(2);

            Console.WriteLine("Count after removal: " + list2.Count);

        }
    }
}