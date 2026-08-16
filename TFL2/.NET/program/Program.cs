
using System;

class Program
{
    static void DoubleValue(ref int number)
    {
        number *= 2;
    }

    static void Main()
    {
        int x = 10;
        DoubleValue(ref x);
        Console.WriteLine(x); // Output: 20
    }
}
