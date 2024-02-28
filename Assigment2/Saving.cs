class SavingsAccount : Account
{
    public double InterestRate { get; set; }
    public SavingsAccount(string accountNumber,double balance,string accName, double interestRate) : base(accountNumber,balance,accName)
    {
        InterestRate = interestRate;
    }

    public override void Withdraw(double amount)
    {
        base.Withdraw(amount);

        Balance += Balance * InterestRate;
        Console.WriteLine($"New balance:{Balance}");
    }
}