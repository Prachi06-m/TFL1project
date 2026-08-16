
namespace Serializable;
public class Employee
{
    public ?string Name{get;set;}
    public decimal Salary{get;set;}
    public ?string Position{get;set;}

 
}
namespace serialization;
using System.Text.Json;
using System.Collections.Generic;

public class RepositoryManager
{
    public void Serialize(List<Employee> employees, string fileName)
    {
        var options = new JsonSerializerOptions { IncludeFields = true };
        var employeesJson = JsonSerializer.Serialize(employees, options);
        File.WriteAllText(fileName, employeesJson);
    }

    public List<Employee> DeSerialize(string fileName)
    {
        string jsonString = File.ReadAllText(fileName);
        List<Employee>? employees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
      
        return employees;
    }
}









using serialization;
using System.Text.Json;
using System.Collections.Generic;
public class Program
{
    public static void Main(string [] args){
        string fileName="Employee.Json";

    List<Employee> employees=new List<Employee>()
    {
        new Employee{
            Id=123,
            Name="payal",
            Salary=1000m
        
    },
    new Employee 
    {
        Id=12,
        Name="prachi",
        Salary=2000m
    }
    };

    RepositoryManager repo=new RepositoryManager();
    repo.Serialize(employees,fileName);
    repo.DeSerialize(fileName);
     foreach (Employee emp in employees)
        {
            Console.WriteLine($"{emp.Id} : {emp.Name}");
        }
    }}

