using System.Text;

public class MultiCounter
{
    #region Fields
    private int size;
    private ChainedModularCounter[] cmc;
    #endregion

    #region Properties
    public int Size => size;
    #endregion


    #region Constructors
    public MultiCounter(int size, int modulus, int step)
    {
        this.size = size;
        cmc = new ChainedModularCounter[size];
        cmc[size - 1] = new ChainedModularCounter(modulus, 0, step, null);
        for (int i = size - 2; i >= 0; i--)
            cmc[i] = new ChainedModularCounter(modulus, 0, step, cmc[i + 1]);
    }
    #endregion
    public void Tick()
    {
        cmc[0].Tick();
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[");
        for (int i = Size - 1; i >= 0; i--)
        {
            sb.Append(cmc[i].Count);
            if (i != 0) 
                sb.Append(",");
        }
        sb.Append("]");
        return sb.ToString();
    }
}