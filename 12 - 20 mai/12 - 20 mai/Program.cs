// Stack, Queue, LinkedList, Heap
// Tree

Tree<int> tree = new Tree<int>();

Random rnd = new Random();

for (int i = 0; i < 20; i++)
{
    int value = rnd.Next(100);
    Console.Write($"Adding {value}...");
    if(tree.Contains(value))
    {
        Console.WriteLine("Already exists");
        continue;
    }
    tree.Add(value);
    //System.Threading.Thread.Sleep(1000);
    Console.WriteLine("Success");    
}


Console.WriteLine($"Tree contains {tree.Count} nodes");

int key = 42;
if (tree.Contains(key))
{
    Console.WriteLine($"Tree contains {key}");
}
else
{
    Console.WriteLine($"Tree does not contain {key}");
}

tree.InorderWalk();