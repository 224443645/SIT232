class DepositTransaction
{
    private Account _account;
    private decimal _amount;
    private bool _executed;
    private bool _success;
    private bool _reversed;

    public bool Executed { get => _executed; }
    public bool Success { get => _success; }
    public bool Reversed { get => _reversed; }

    public DepositTransaction(Account account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }

    /// <summary>
    /// prints transaction details
    /// </summary>
    public void Print()
    {
        Console.WriteLine("The transaction was a " + (_success ? $"sucess. ${_amount}(s) were deposited." : "failure"));
    }

    /// <summary>
    /// Executes transaction
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public void Execute()
    {
        if (_executed)
        {
            throw new InvalidOperationException("Deposit, has already been made");
        }
        _executed = true;

        if (_amount < 0)
        {
            throw new InvalidOperationException("Insufficent Funds in acconut for withdrawel");
        }

        _account.Deposit(_amount);

        _success = true;
    }

    /// <summary>
    /// Rollsback transaction, can only be called if the transaction has already been executed.
    /// cannot be called twice
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public void Rollback()
    {
        if (!_executed)
        {
            throw new InvalidOperationException("Withdrawl must have occured before rolling back");
        }
        if (_reversed)
        {
            throw new InvalidOperationException("Transaction has already been reversed.");
        }

        _account.Withdraw(_amount);
        _reversed = true;
    }


}