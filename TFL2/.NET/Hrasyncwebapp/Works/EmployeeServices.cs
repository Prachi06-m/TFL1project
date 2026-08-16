using HR.Models;
namespace HR.Services;
public class EmployeeServices
{
    public async Task<List<Employee>>GetEmployeesAsync()
    {
    await Task.Delay(1000);
    
        return new List<Employee>
        {
            new Employee{Id=101,Name="Prachi",Department="IT",Salary=50000},
            new Employee{Id=102,Name="Payal",Department="Finance",Salary=60000},
            new Employee{Id=103,Name="Purva",Department="IT",Salary=70000}

        };
// List<Employee> Employees=new Employee
        
    }
    public async Task <double>CalculateBonusAsync(Employee emp)
    {
        await Task.Delay(1500);
        return emp.Salary*0.6;
    }
    public async Task SaveEmployeeAsync(Employee emp)
    {
        await Task.Delay(2000);
        Console.WriteLine($"Emplyoee Saved Aschronisely :{emp.Name}");
        
    }
}


