public class Program
{
    public static void Main(string [] args)
    {
      int[,] numbers = new int[2, 3]
    {
    { 1, 2, 3 },
    { 4, 5, 6 }
    };
    Console.WriteLine(numbers[0, 0]); // 1
    Console.WriteLine(numbers[1, 2]); // 6
    

    }
}