using System.Collections;

public class MaxHeap<T>:IEnumerable<T>  where T : IComparable<T>
{
    #region Fields
    private T[] data;
    #endregion

    #region Properties
    public int HeapSize { get; set; }
    #endregion

    #region Constructors
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
    #endregion

    #region Methods
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

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 1; i <= HeapSize; i++)
        {
            yield return data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return data.GetEnumerator();
    }


    public override string ToString()
    {
        return "[" + string.Join(", ", data[1..(HeapSize + 1)]) + "]";
    }
    public void HeapSort()
    {
        for(int i = HeapSize; i > 1; i--)
        {
            (data[1], data[i]) = (data[i], data[1]);
            HeapSize--;
            MaxHeapify(1);
        }
    }

    public T HeapMaximum()
    {
        if (HeapSize < 1)
            throw new InvalidOperationException("Heap is empty");
        return data[1];
    }
    public T HeapExtractMax()
    {
        if (HeapSize < 1)
            throw new InvalidOperationException("Heap is empty");
        T max = data[1];
        data[1] = data[HeapSize];
        HeapSize--;
        MaxHeapify(1);
        return max;
    }
    public void HeapIncreaseKey(int i, T key)
    {
        if (key.CompareTo(data[i]) < 0)
            throw new ArgumentException("New key is smaller than current key");
        data[i] = key;
        while (i > 1 && data[Parent(i)].CompareTo(data[i]) < 0)
        {
            (data[i], data[Parent(i)]) = (data[Parent(i)], data[i]);
            i = Parent(i);
        }
    }

    public void HeapInsert(T key)
    {
        HeapSize++;

        if(HeapSize >= data.Length)
        {
            Array.Resize(ref data, data.Length * 2);
        }

        data[HeapSize] = default(T);
        HeapIncreaseKey(HeapSize, key);
    }
    #endregion
}