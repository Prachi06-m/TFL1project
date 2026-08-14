using partial;
public class Program{
 public static void Main(string[]args)
{
    BankAccount acc=new BankAccount();
    acc.AccountID=234;
    acc.name="prachi";
    acc.Balance=5000m;


    acc.Deposit(2000);
    acc.Withdraw(6000);
    acc.InterestRate(0.05m);

}
}