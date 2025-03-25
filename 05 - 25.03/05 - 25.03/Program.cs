Stack<int> st = new Stack<int>();

for (int i = 0; i < 10; i++)
{
    st.Push(i);
}

Console.WriteLine($"Stiva contine {st.Count} elemente");

while(st.Count > 0)
{
    Console.WriteLine(st.Pop());
}

MyStack myStack = new MyStack();



