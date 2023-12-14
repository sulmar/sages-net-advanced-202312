namespace LockExample;
class BankAccountService
{
    public void Transfer(BankAccount accountA, BankAccount accountB, decimal amount)
    {
        accountA.Withdraw(amount);
        accountB.Deposit(amount);
    }

}

class BankAccount
{
    public decimal Balance { get; private set; }

    private object _sync = new object();

    public BankAccount(decimal initBalance)
    {
        Balance = initBalance;
    }

    public void Deposit(decimal amount)
    {
        lock (_sync)
        {
            Balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        lock (_sync)
        {

            Balance -= amount;

        }
    }
}