using System;

public class Program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);
        Console.WriteLine();

        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);
        Console.WriteLine();

        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);
        Console.WriteLine();

        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);
        Console.WriteLine();

        WriteEvensThrough100();
        Console.WriteLine();

        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);
        Console.WriteLine();

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);
        Console.WriteLine();

        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);
        Console.WriteLine();

        OutputRightTriangle(4);
        Console.WriteLine();
        OutputRightTriangle(6);
        Console.WriteLine();
        OutputRightTriangle(-4);
        Console.WriteLine();
        OutputRightTriangle(-6);
        Console.WriteLine();
        OutputRightTriangle(0);
        Console.WriteLine();

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
            Console.Write(current + " ");
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
            Console.Write(i + " ");
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
            Console.Write(n + " ");
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
            Console.Write(i + " ");
        }
        Console.WriteLine("");
    }

    public static void WriteEvensThrough100()
    {
        for (int i = 0; i <= 100; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public static void FindSum(int n)
    {
        int sum = 0;
        if (n < 1)
        {
            for (int i = n; i <= 1; i++)
            {
                sum += i;
            }
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int sum = 0;
        if (n == 0)
        {
            Console.WriteLine("0");
            return;
        }
        if (n < 1)
        {
            for (int i = n; i <= 1; i++)
            {
                sum += i % 2 == 0 ? i : 0;
            }
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                sum += i % 2 == 0 ? i : 0;
            }
        }



        Console.WriteLine(sum);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;
        if (n == 0)
        {
            Console.WriteLine("0");
            return;
        }
        if (n < 1)
        {
            for (int i = n; i <= 1; i++)
            {
                sum += i % 2 == 0 ? 0 : i;
            }
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                sum += i % 2 == 0 ? 0 : i;
            }
        }
        Console.WriteLine(sum);
    }

    public static void OutputRightTriangle(int _base)
    {
        if (_base == 0) OutOfRangeMessage(_base);
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