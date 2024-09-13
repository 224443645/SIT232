class Account
{
    private decimal _balance;
    private string _name;

    public string Name
    {
        get => _name;
    }

    public Account(string name, decimal balance)
    {
        _name = name;
        _balance = balance;
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        _balance -= amount;
    }

    public void Print()
    {
        Console.WriteLine($"balance: {_balance}, name: {_name}");
    }

}