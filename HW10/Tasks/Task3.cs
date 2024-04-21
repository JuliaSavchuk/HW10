namespace HW10
{
    public class CircularQueue<T>
    {
        public T[] Items;
        public int Capacity;
        public int Head;
        public int Tail;
        public int Count;

        public CircularQueue(int capacity)
        {
            Capacity = capacity;
            Items = new T[capacity];
            Head = 0;
            Tail = 0;
            Count = 0;
        }

        public void Enqueue(T item)
        {
            Items[Tail] = item;
            Tail = (Tail + 1) % Capacity;
            Count++;
        }

        public T Dequeue()
        {
            T item = Items[Head];
            Head = (Head + 1) % Capacity;
            Count--;
            return item;
        }

        public T Peek()
        {
            return Items[Head];
        }
    }
}
