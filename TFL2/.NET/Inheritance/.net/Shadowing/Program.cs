

using System.Transactions;

namespace Shadowing;
public class Employee
{   
    double salary=200;
    public virtual double Calculatesalary()
    {return salary;}
}



public class SalesEmployee:Employee
{
    double salary=5000;
    double sales=200;
    double commision=500;
    
    
    public new double Calculatesalary()
    {
        return salary+(sales* commision);
    }


public static void Main(string[]args)
    {
        SalesEmployee sal=new SalesEmployee();
        double salary=sal.Calculatesalary();
        
        

        Console.WriteLine(salary);
    }
}
































