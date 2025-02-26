internal class Ladder
{
    private Frame f1, f2;
    private VertBar v;

    public Ladder(int w, int v1, int v2)
    {
        f1 = new Frame(w, v1);
        v = new VertBar(v2);
        f2 = new Frame(w, v1);
    }
}