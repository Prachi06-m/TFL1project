namespace Hrsynclab;
public class Hrservices
{
public async Task<List<Employee>>GetEmployeesAsync()
{
    await Task.Delay(1000);
    
        return new List<Employee>
        {
            new Employee{Id=101,Name="Prachi",Department="IT",Salary="50000"},
            
            new Employee{Id=101,Name="Payal",Department="hr",Salary="80000"},
            
            new Employee{Id=101,Name="Prem",Department="finance",Salary="50000"},
            
            new Employee{Id=101,Name="Pranu",Department="IT",Salary="30000"}
        };
    
}
public Async Task async Task<double> CalculateBonusAsync(emp Employee )
{
    await Task .Delay(1000);
    return emp .salary*0.10
}
public Async Task SaveEmployeeAsync(emp Employee )
{
    await Task.Delay(1000);
    Console.WriteLine("saved Asynchronise changes succesefully");
}
}
