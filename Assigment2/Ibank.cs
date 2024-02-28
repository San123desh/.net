public interface IBankAccount
{
    string AccountNumber { get; }
    decimal Balance { get; }
    
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
}