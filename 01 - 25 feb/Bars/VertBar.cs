internal class VertBar
{
    public int Height { get; }

    public VertBar(int height)
    {
        this.Height = height;
        for (int i = 0; i < Height; i++)
        {
            Console.WriteLine("|");
        }
    }
}