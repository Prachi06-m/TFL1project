namespace Banking;

public class Account
{
    public decimal Balance{get;set;}
    public virtual void ProcessTransaction(decimal amount)
    {
        Balance+=amount;
        Console.WriteLine($"Generic Account:Deposited {amount}.Balance:{Balance}");

    }
}
namespace Banking;

public class Account
{
    public decimal Balance{get;set;}
    public virtual void ProcessTransaction(decimal amount)
    {
        Balance+=amount;
        Console.WriteLine($"Generic Account:Deposited {amount}.Balance:{Balance}");

    }
}







 


