namespace Banking;



public class Account
{
    public decimal Balance {get;set;}

      public void Deposit(decimal amount)
     {  
       Balance+=amount;
        Console.WriteLine($"Deposited {amount}.New Balance:{Balance}");
       }    


       public void Withdraw(decimal amount)
       {
        if(Balance>=amount)
        {
        Balance-=amount;
        Console.WriteLine($"Withdrew{amount}.New Balance:{Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");

        }
       }


}   