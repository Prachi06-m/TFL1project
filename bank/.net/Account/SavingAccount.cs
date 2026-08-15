namespace Banking;
class SavingAccount:Account
{
    public decimal IntrestRate{get;set;}=0.05m;

    public void ApplyIntrestRate()
    {
        Balance+=Balance *IntrestRate;
        Console.WriteLine($"Intrest applied.New Balance{Balance}");

    }


}