
using StudentApp;
public class Program
{
    public static void Main (string[]args)
    {
    
    Student student=new Student(21,1,"prachi");
    Console.WriteLine($"name:{student.Name},Id:{student.Id},Age:{student.Age}");
    
    student.Display();

    }
}