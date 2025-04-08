public class MaxHeap<T>  where T : IComparable<T>
{
    private T[] data;
    public int HeapSize { get; set; }
    public MaxHeap(T[] data)
    {
        this.data = new T[data.Length + 1];
        for (int i = 0; i < data.Length; i++)
        {
            this.data[i + 1] = data[i];
        }
        HeapSize = data.Length;

        BuildMaxHeap();
    }
    private int Parent(int i)
    {
        return i / 2;
    }
    private int Left(int i)
    {
        return i * 2;
    }
    private int Right(int i)
    {
        return i * 2 + 1;
    }
    private void MaxHeapify(int i)
    {
        int left = Left(i);
        int right = Right(i);
        int largest = i;
        if (left <= HeapSize && data[largest].CompareTo(data[left]) < 0)
            largest = left;
        if (right <= HeapSize && data[largest].CompareTo(data[right]) < 0)
            largest = right;

        if(largest != i)
        {
            (data[i], data[largest]) = (data[largest], data[i]);
            MaxHeapify(largest);
        }
    }
    private void BuildMaxHeap()
    {
        for (int i = HeapSize / 2; i >= 1; i--)
        {
            MaxHeapify(i);
        }
    }
}