using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace IAccount;
public interface IAccount
{
   public void Deposit(decimal amount);
    public void Withdraw(decimal amount);
    public void Checkbalance();

}

public class SavingAccount:IAccount
{
    public decimal Balance=0;
    public decimal Interestrate=0.05m;
    public void Deposit(decimal amount)
    {
        Balance+=amount;
        Console.WriteLine($"Deposited amount{amount},Balance:{Balance}");
    }
    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
        Balance-=amount;
        Console.WriteLine($"withdraw amount{amount},Balance:{Balance}");
        }
        else
        {
            Console.WriteLine("Saving Account:Insufficient Balance");
        }
   }
      public void Checkbalance()
    {
        Console.WriteLine($"Check Balance:{Balance}");
    }

}


public class CurruntAccount:IAccount
{     public decimal Balance=0;
     public decimal overdraftlimit=500;

    public void Deposit(decimal amount)
    {
        Balance+=amount+(overdraftlimit+amount);
        Console.WriteLine($"Deposited amount{amount}.Balance{Balance}");

    }
    public void Withdraw(decimal amount)
{
    if(Balance+overdraftlimit>=amount)
    {
    Console.WriteLine($"Withdrew amount(amount). Balance.{Balance}");
    }
}
     public void Checkbalance()
        {
         Console.WriteLine($"Check Balance:{Balance}");   
        }

}    

    
public class Program
{
    public static void Main(string[]args)
    {
        IAccount Acc = new SavingAccount();
        Acc.Deposit(100m);
        Acc.Withdraw(200m);
        Acc.Checkbalance();


        IAccount Account =new CurruntAccount();
        Account.Deposit(100m);
        Account.Withdraw(200m);
        Account.Checkbalance();
    }
}