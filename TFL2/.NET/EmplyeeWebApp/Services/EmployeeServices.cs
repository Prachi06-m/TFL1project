using System.ComponentModel;

namespace empservices;
public class EmployeeServices
{
    public static async Task<List<Employee>>GetAll()
    {
        await Task.Delay(1000);
        List<Employee>employees=new List<Employee>();
        {
         employees.Add(new Employee{ Id=23, Salary=50000,Name="Prachi"});
        employees.Add(new Employee{Id=24, Salary=60000,Name="Payal" });
        employees.Add(new Employee{Id=25, Salary=70000,Name="saniya" });
        employees.Add(new Employee{ Id=26, Salary=80000,Name="sanika"});
        
        return employees;
        };
    }
    public static string Insert()
    {
        Console.WriteLine("insertion in progress");
        return "Employee inserted Sucessefully";
    }
    

}
























































































































































