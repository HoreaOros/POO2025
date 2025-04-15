public class ChainedModularCounter : ModularCounter
{
    private ChainedModularCounter next;
    public ChainedModularCounter(int modulus, ChainedModularCounter next) : this(modulus, 0, next)
    {
    }
    public ChainedModularCounter(int modulus, int count, ChainedModularCounter next) : this(modulus, count, 1, next)
    {
    }
    public ChainedModularCounter(int modulus, int count, int step, ChainedModularCounter next) : base(modulus, count, step)
    {
        this.next = next;
    }
    public override void Tick()
    {
        int oldValue = Count;
        base.Tick();

        if (oldValue + Step >= Modulus)
        {
            if (next != null)
                next.Tick();
        }
    }
}