using System;

public class Program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);

        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);

        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);

        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);


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
            Console.Write(current+" ");
            current++;
        }
        Console.WriteLine("");
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
            Console.Write(i+" ");
        }
        Console.WriteLine("");
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
            Console.Write(n+" ");
            n--;
        }
        Console.WriteLine("");
    }

    public static void WriteNThrough1_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
            return;
        }
        for (int i = n; i >= 1; i--)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine("");
    }

    public static void WriteEvensThrough100()
    {
        for (int i = 0; i <= 100; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    public static void FindSum(int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += i;
        }
        sum += n;
        Console.WriteLine(sum);
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int current = 0;
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        int sum = 0;
        while (current < n)
        {
            if (current % 2 == 0)
            {
                sum += current;
            }
            current++;
        }
        while (current > n)
        {
            if (current % 2 == 0)
            {
                sum += current;
            }
            current--;
        }
        sum += n % 2 == 0 ? n : 0;
        Console.WriteLine(sum);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int current = 1;
        if (n == 0)
        {
            Console.WriteLine("0");
        }
        int sum = 0;
        while (current < n)
        {
            if (current % 2 == 0)
            {
                current++;
                continue;
            }
            sum += current;
            current++;
        }

        while (current < n)
        {
            if (current % 2 == 0)
            {
                current--;
                continue;
            }
            sum += current;
            current--;
        }
        sum += n % 2 == 0 ? 0 : n;
        Console.WriteLine(sum);
    }

    public static void OutputRightTriangle(int _base)
    {
        int len = 1;
        if (_base < 0)
        {
            len = Math.Abs(_base);
            while (len >= 1)
            {
                for (int i = 0; i < len; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                len--;
            }
        }
        else
        {
            while (len <= _base)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat("*", len)));
                len++;
            }
        }
    }

    public static void OutOfRangeMessage(int n)
    {
        Console.WriteLine($"{n} is out of range.");
    }
}