internal class VertBar
{
    private int height;
    public int Height => height;
    public VertBar(int height)
    {
        this.height = height;
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine("|");
        }
    }
}