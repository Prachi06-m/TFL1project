using System.Security.Cryptography.X509Certificates;
using HR.Services;
using Microsoft.VisualBasic;
using HR.Models;

public class Program
{
    public static async Task Main (String[]args)
    {
    Console.WriteLine("Program Started Aschronisely");
    EmployeeServices Works=new EmployeeServices();
     
     var employees =await Works.GetEmployeesAsync();
     Console.WriteLine("Employees Loaded");
    
    //employees.ForEach(emp =>Console.WriteLine(emp));
    foreach(Employee emp in employees)
        {
            Console.WriteLine(emp);
          
        }
     
     double Bonus=await Works.CalculateBonusAsync(employees[0]);
     Console.WriteLine($"Bonus for :{employees[0].Name}:{Bonus}");
     await Works.SaveEmployeeAsync(employees[0]);
     Console.WriteLine("Process is completed");

    }
}
     



