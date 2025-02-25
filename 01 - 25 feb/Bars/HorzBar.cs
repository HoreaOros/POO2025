internal class HorzBar
{
    public int Length { get; }

    public HorzBar(int len)
    {
        this.Length = len;
        Console.Write('+');
        for (int i = 0; i < Length; i++)
            Console.Write("-");
        Console.Write('+');

        Console.WriteLine();
    }
}