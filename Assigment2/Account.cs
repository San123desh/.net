class Account
{
    public string AccountNumber { get; }
    public double Balance { get; set; }
    public string name;
    public Account(string accountNumber,double balance,string accName)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        name = accName;
    }
    public virtual void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            return Balance;
            Console.WriteLine($"Withdrawal {amount},Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }
}