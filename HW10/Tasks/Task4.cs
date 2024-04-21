namespace HW10
{
    
    public class LinkedList<T>
    {
        private Node<T> head;
        private int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                AddFirst(data);
            }
            else
            {
                Node<T> newNode = new Node<T>(data);
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                count++;
            }
        }

        public T RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }
            T removedData = head.Data;
            head = head.Next;
            count--;
            return removedData;
        }

        public int Count
        {
            get { return count; }
        }

        public void Print()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
