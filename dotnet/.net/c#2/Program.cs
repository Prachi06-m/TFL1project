namespace system;
public class Program
{
    public static void Main (string[]args)
    {
        List<Student>students=new List<Student>()
        {
            new Student {Name="John",Age=20},
            new Student{Name="Prachi",Age=23}
        };
        foreach(Student student in students)
        {
            Console.WriteLine($"Name:{student.Name},Age:{student.Age}");
        }

    }
}