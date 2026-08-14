namespace partial;
public partial class BankAccount
{
    public void Deposit(decimal amount)
    {
        Balance+=amount;
        Console.WriteLine($"Deposited amount:{amount}.Balance:{Balance}");

    }
    public  void Withdraw(decimal amount)
    {
        Balance-=amount;

        if(Balance>=amount)
        {
            Console.WriteLine($"Withdrew amount{amount}.Balance:{Balance}");
        }
        else
        {

            Console.WriteLine("insufficient Balance");
         }
    }


    public  void InterestRate(decimal rate)
    {
        Balance+=Balance*rate;
        Console.WriteLine($"interest rate:{rate}.New Balance:{Balance}");
    }




}