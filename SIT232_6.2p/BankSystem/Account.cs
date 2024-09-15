/// <summary>
/// Account object
/// </summary>
class Account
{
    private decimal _balance;
    private string _name;

    public string Name
    {
        get => _name;
    }

    public decimal Balance { get => _balance; }

    public Account(string name, decimal balance)
    {
        _name = name;
        _balance = balance;
    }
    /// <summary>
    /// Deposits specified amount into account
    /// </summary>
    /// <param name="amount">Ammount to be deposited, cannot be less than or equal to 0</param>
    /// <returns>Returns true if successful, false if not</returns>
    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return false;
        }
        _balance += amount;
        return true;
    }
    /// <summary>
    /// Withdraws specified amount from account
    /// </summary>
    /// <param name="amount">Amount to be withdrawn cannot be less than or equal to 0</param>
    /// <returns>Returns true if successful, false if not</returns>
    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || _balance - amount < 0)
        {
            return false;
        }
        _balance -= amount;
        return true;
    }

    /// <summary>
    /// Prints account name and balance to standard output
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"balance: {_balance}, name: {_name}");
    }

}