
using Account;
public class Program
{
    public static void Main(string[]args)
{
    Acount ac=new Acount(150);
    ac.Underbalance+=Dopayment;
    ac.Underbalance+=BlockAccount;
    ac.Overbalance+=PayTax;
    ac.Overbalance+=BlockTax;

    ac.Withdraw(200);
    

}
public static void Dopayment()
    {
        Console.WriteLine("pay rs.500");
    }
public static void BlockAccount()
    {
        Console.WriteLine("your account has been Blocked");

    }
public static void PayTax()
    {
        Console.WriteLine("pay 5% Tax in your income");
    } 

 public static void BlockTax()
    {
        Console.WriteLine("pay 10% Tax in your income");
    }     
}
