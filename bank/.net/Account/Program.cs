using Banking;

class  Program
{
    public static void Main (string []args)
    {
        SavingAccount sa=new SavingAccount();
        sa.Balance=100000;
        sa.Deposit(2000);
        sa.Withdraw(3000);
        sa.ApplyIntrestRate();
    }
}