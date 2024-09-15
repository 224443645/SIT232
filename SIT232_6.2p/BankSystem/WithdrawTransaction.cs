class WithdrawTransaction
{
    private Account _account;
    private decimal _amount;
    private bool _executed;
    private bool _success;
    private bool _reversed;

    public bool Executed { get => _executed; }
    public bool Success { get => _success; }
    public bool Reversed { get => _reversed; }

    public WithdrawTransaction(Account account, decimal amount)
    {
        _account = account;
        _amount = amount;
    }
    /// <summary>
    /// prints transaction details
    /// </summary>
    public void Print()
    {
        Console.WriteLine("The transaction was a " + (_success ? $"sucess. ${_amount}(s) were withdrawn." : "failure"));
    }
    /// <summary>
    /// Executes transaction
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public void Execute()
    {
        if (_executed)
        {
            throw new InvalidOperationException("Withrdraw has already been made");
        }
        _executed = true;

        if (!_account.Withdraw(_amount))
        {
            throw new InvalidOperationException("Insufficent Funds in acconut for withdrawel");
        };

        _success = true;
    }
    /// <summary>
    /// Rolls back transaction, cannot be called twice. Can only be called once the transaction has been executed
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

        _account.Deposit(_amount);
        _reversed = true;
    }
}