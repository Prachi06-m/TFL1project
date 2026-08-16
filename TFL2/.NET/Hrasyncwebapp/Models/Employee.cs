namespace HR.Models;
public class Employee
{
    public int Id;
    public String ? Name;
    public string ?Department;
    public double Salary;

    public override string ToString()
    {
        return $"{Id},{Name},{Department},{Salary}";
    }


}
