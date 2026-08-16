namespace College;
public class Student
{
int id;
string name;
int age;



public Student()
{
this.id=1;
this.name="prachi";
this.age=20;
}

public Student(int id ,string name,int age)
{
    this.id=id;
    this.name=name;
    this.age=age;
}
public void ShowInfo()
{
Console.WriteLine("id"+id);
Console.WriteLine("name"+name);
Console.WriteLine("age"+age);    
}
}