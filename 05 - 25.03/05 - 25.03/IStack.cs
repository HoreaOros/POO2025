public interface IStack<T>
{
    int Capacity { get; }
    int Count { get; }

    T Peek();
    T Pop();
    void Push(T value);
}
