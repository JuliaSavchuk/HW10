namespace HW10
{
    public class PriorityQueue<T>
    {
        public List<T> Items;
        public Comparison<T> Comparison;

        public PriorityQueue(Comparison<T> comparison)
        {
            Items = new List<T>();
            Comparison = comparison;
        }

        public void Enqueue(T item)
        {
            Items.Add(item);
            Items.Sort(Comparison);
        }

        public T Dequeue()
        {
            T item = Items[0];
            Items.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            return Items[0];
        }

        public int Count
        {
            get { return Items.Count; }
        }
    }
}
