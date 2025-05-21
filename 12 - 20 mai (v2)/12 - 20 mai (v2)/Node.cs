namespace BST
{
    internal class Node
    {
        public int Key { get; set; }
        public int Frequency { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public Node? Parent { get; set; }
    }
}