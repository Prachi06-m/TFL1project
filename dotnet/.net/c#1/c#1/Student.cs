using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace StudentApp;
public class Student
{
   public int Age;
    public int Id;
    public string Name;
//Default Constructor
public Student()
    {
        Console.WriteLine("student object is created");

}
//Parameterized Constructor
public Student(int Age,int id,string name)
{
this.Age=Age;
this.Id=id;
this.Name=name;
}
public void Display()
    {
        Console.WriteLine("object creation Succesefull");
    }


}








