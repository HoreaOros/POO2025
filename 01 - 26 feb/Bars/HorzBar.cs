﻿internal class HorzBar
{
    private int length;
    public int Length
    { 
        get
        {
            return length;
        }
    }

    public HorzBar(int length)
    {
        this.length = length;
        Console.Write("+");
        for(int i = 0; i < length; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("+");
    }
}