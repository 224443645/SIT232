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

    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return false;
        }
        _balance += amount;
        return true;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0 || _balance - amount < 0)
        {
            return false;
        }
        _balance -= amount;
        return true;
    }

    public void Print()
    {
        Console.WriteLine($"balance: {_balance}, name: {_name}");
    }

}