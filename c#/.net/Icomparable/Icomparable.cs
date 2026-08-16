namespace Company;
using System.Collections.Generic;
public class Employee:IComparable<Employee>
{
public string? Name{get;set;}
 public decimal ?Salary{get;set;}

//
public decimal CompareTo(Employee other)
    {
        return
        Salary.CompareTo(other.Salary);
    }
}