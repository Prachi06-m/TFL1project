VC//using System;

public class Param
{
    static int Add(params int[] numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }

   public static void Main(string[]args)
    {
        Console.WriteLine(Add(10, 20));          // 30
        Console.WriteLine(Add(1, 2, 3, 4, 5));   // 15
        Console.WriteLine(Add());                // 0
    }
}