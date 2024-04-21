namespace HW10
{
    public class Task1
    {
        public static void SwapValue<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
