public class FixedDepositAccount : IBankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; private set; }
    public DateTime MaturityDate { get; }

    public FixedDepositAccount(string accountNumber, DateTime maturityDate)
    {
        AccountNumber = accountNumber;
        MaturityDate = maturityDate;
    }

    public void Deposit(decimal amount)
    {
        
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (DateTime.Now < MaturityDate)
        {
            Console.WriteLine("Cannot withdraw from fixed deposit before maturity date.");
        }
        else
        {
            Balance -= amount;
        }
    }
}