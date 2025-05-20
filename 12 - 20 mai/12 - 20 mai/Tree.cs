// Stack, Queue, LinkedList, Heap
// Tree

public class Node<T> where T : IComparable<T>
{
    public T Data { get; set; }
    public Tree<T> Left { get; set; }
    public Tree<T> Right{ get; set; }
}

public class Tree<T> where T : IComparable<T>
{
    Node<T> root = null;
    public int Count 
    { 
        get
        {
            return CountRec(this);
        }
        private set
        {

        }
    }

    private int CountRec(Tree<T> tree)
    {
        if(tree == null)
        {
            return 0;
        }
        else
        {
            return 1 + CountRec(tree.root.Left) + CountRec(tree.root.Right);
        }
    }

    public Tree()
    {
    }

    public void Add(T value)
    {
        Node<T> newNode = new Node<T>();
        newNode.Data = value;
        newNode.Left = newNode.Right = null;
        if (root == null)
        {
            root = newNode;
        }
        else
        {
            AddRec(this, newNode);
        }
    }

    private Tree<T> AddRec(Tree<T> tree, Node<T> newNode)
    {
        if(tree == null)
        {
            tree = new Tree<T>();
            tree.root = newNode;
            return tree;
        }
        else
        {
            if (newNode.Data.CompareTo(tree.root.Data) < 0)
            {
                tree.root.Left = AddRec(tree.root.Left, newNode);
            }
            else if(newNode.Data.CompareTo(tree.root.Data) > 0)
            {
                tree.root.Right = AddRec(tree.root.Right, newNode);
            }
            else
            {
                return tree;
            }
            return tree;
        }
    }
    public bool Contains(T value)
    {
        if(root == null)
        {
            return false;
        }
        Tree<T> p = this;
        while (p != null)
        {
            if (value.CompareTo(p.root.Data) == 0)
            {
                return true;
            }
            else if (value.CompareTo(p.root.Data) < 0)
            {
                p = p.root.Left;
            }
            else
            {
                p = p.root.Right;
            }
        }
        return false;
    }

    internal void InorderWalk()
    {
        InorderWalkHelper(this);
    }

    private void InorderWalkHelper(Tree<T> tree)
    {
        if(tree != null)
        {
            InorderWalkHelper(tree.root.Left);
            Console.WriteLine(tree.root.Data);
            InorderWalkHelper(tree.root.Right);
        }
    }
}