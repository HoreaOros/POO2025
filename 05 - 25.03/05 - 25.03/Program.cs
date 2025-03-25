Stack<int> st = new Stack<int>();

for (int i = 0; i < 10; i++)
{
    st.Push(i);
}

//Console.WriteLine($"Stiva contine {st.Count} elemente");

//while(st.Count > 0)
//{
//    Console.WriteLine(st.Pop());
//}

MyStack myStack = new MyStack();


MyStack<int> intStack = new MyStack<int>();
intStack.Push(0);
intStack.Push(1);
intStack.Push(2);
MyStack<string> stringStack = new MyStack<string>();


MyStackBasic<float> floatStack = new MyStackBasic<float>();
floatStack.Push(0.3f);
floatStack.Push(1.4f);
floatStack.Push(2.5f);


PrintStack(intStack);
PrintStack(floatStack);

static void PrintStack<T>(IStack<T> stack)
{ 
    while (stack.Count > 0)
    {
        Console.WriteLine(stack.Pop());
    }
}
