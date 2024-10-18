using System;

public class Program
{
    public static void Main(string[] args)
    {
        WriteNThrough1_For(5);
    }

    public static void Write1ThroughN_While(int n)
    {
        int current = 1;
        if (n < 1)
        {
            OutOfRangeMessage(n);
            return;
        }
        while (current <= n)
        {
            Console.WriteLine(current);
            current++;
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
            return;
        }
        while (n >= 1)
        {
            Console.WriteLine(n);
            n--;
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
            return;
        }
        for (int i = n; i >= n; i--)
        {
            Console.WriteLine(i);
        }
    }

    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine($"{n} is out of range.");
    }
}