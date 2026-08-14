namespace Account;

public class Acount
{
   public delegate void Accountoperation();
    private int Balance;
    public event Accountoperation ?Underbalance;
    public event Accountoperation ?Overbalance;
    
    public Acount(int amount)
    {
        Balance =amount;
    }
    public void Deposit(int amount)
    {
        Balance+=amount;
        if (Balance>10000)
        {
            Overbalance?.Invoke();
        }
    }
     public void  Withdraw(int amount)
    {
        Balance-=amount;
        if (Balance<500)
        {
            Underbalance?.Invoke();
        }
    }


}