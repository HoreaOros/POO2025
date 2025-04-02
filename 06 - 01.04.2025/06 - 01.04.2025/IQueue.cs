namespace _06___01._04._2025
{
    public interface IQueue<T>
    {
        int Count { get; }
        void Enqueue(T? item);
        T? Dequeue();
    }
}