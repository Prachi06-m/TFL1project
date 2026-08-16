public class Area
{
 public static void Calculate(float length,out float area ,out float perimeter)
 {
    area=length*length;
    perimeter=4*length;
 }
 public static void Main(string[] args)
 {
  float area1;
  float perimeter1;

  Calculate(5,out area1,out perimeter1);
  Console.WriteLine(area1);
  Console.WriteLine(perimeter1); 
 }
}
