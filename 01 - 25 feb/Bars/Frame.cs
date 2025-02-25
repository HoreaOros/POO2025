internal class Frame
{
    private HorzBar h1, h2;
    private VertBar v;

    public Frame(int length, int height)
    {
        this.h1 = new HorzBar(length);
        this.v = new VertBar(height);
        this.h2 = new HorzBar(length);
    }

    public int Height
    {
        get
        {
            return v.Height;
        }
    }

    public int Width => h1.Length;
}