namespace Account;
public interface IAccount
{
  public  void  Deposit(decimal amount);
   public void Withdraw(decimal amount);
   public void CheckBalance();

}


class SavingAccount:IAccount
{
    public decimal Balance=0;
    public decimal Interestrate=0.05m;
    
    public void Deposit(decimal amount)

    {
        
        Balance+=amount+(Interestrate*Balance);

        Console.WriteLine($"Deposited amount{amount}.Balance:{Balance}");


    }
       public void Withdraw(decimal amount)
    {
        if(Balance>=amount)
        {
            Balance-=amount;
        }
        else
        {
            Console.WriteLine("Balance is insufficient!");
        }

    }
    public decimal CheckBalance()
   {
      Console.WriteLine($"Balance={Balance}");
   }

    }


public class CurrentAccount:IAccount
{
    public decimal Balance=0;
    public decimal overdraftLimit=30000;
    
    public void Deposit(decimal amount)
    {
       Balance+=amount;
       Console.WriteLine( $"CurrentAccount {amount}.Balance:{Balance}");
    }
    

    }

    public void Withdraw(decimal amount)

    {
    if(Balance+overdraftLimit>=amount)
    {
        Balance-=amount-overdraftLimit
        Console.WriteLine(CurrentAccount withdrew(amount).Balance{Balance});
    }
    else
    {
        Console.WriteLine("overdraftlimit exceed");
    }
    }
    public decimal CheckBalance()
   {
      Console.WriteLine($"Balance={Balance}");
   }