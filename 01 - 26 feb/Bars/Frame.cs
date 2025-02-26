internal class Frame
{

    private HorzBar h1, h2;
    private VertBar v;

    public int Length
    {
        get
        {
            return h1.Length;
        }
    }
    public int Height => v.Height;
    public Frame(int length, int height)
    {
        h1 = new HorzBar(length);
        v = new VertBar(height);
        h2 = new HorzBar(length);
    }
}