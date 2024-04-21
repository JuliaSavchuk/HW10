namespace HW10
{
    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> head;
        private DoublyLinkedListNode<T> tail;
        private int count;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Add(T value)
        {
            var newNode = new DoublyLinkedListNode<T>(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
            count++;
        }

        public bool Remove(T value)
        {
            if (head == null)
                return false;

            if (head.Value.Equals(value))
            {
                head = head.Next;
                if (head != null)
                    head.Previous = null;
                else
                    tail = null;
                count--;
                return true;
            }

            var current = head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    current.Previous.Next = current.Next;
                    if (current.Next != null)
                        current.Next.Previous = current.Previous;
                    else
                        tail = current.Previous;
                    count--;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public int Count => count;

        // Інші методи і властивості можуть бути додані за потреби
    }
}
