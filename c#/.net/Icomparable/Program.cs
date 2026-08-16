using Company;
using System.Collections.Generic;


public class Program
{
    public static void Main (string[]args)
    {
        List<Employee>employees=new List<Employee>()
        {
            new Employee{Name="Prachi",Salary=10000},
            new Employee{Name="Payal",Salary=50000},
            new Employee{Name="Sayali",Salary=70000}
        };
         employees.Sort();
         Console.WriteLine("Employees sorted by Salary:");
        
            foreach(Employee emp in employees)
            {
                Console.WriteLine($"Name:{emp.Name},Salary:{emp.Salary}");
            }
        
}
}
