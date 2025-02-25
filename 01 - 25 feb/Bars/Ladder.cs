internal class Ladder
{
    private Frame f1, f2;
    private VertBar v;

    public Ladder(int length, int h1, int h2)
    {
        f1 = new Frame(length, h1);
        v = new VertBar(h2);
        f2 = new Frame(length, h1);
    }
}