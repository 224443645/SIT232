class WithdrawTransaction : Transaction
{
    private Account _account;
    private bool _executed;
    private bool _reversed;
    private DateTime _dateStamp;

    public bool Reversed { get => _reversed; }
    public new DateTime DateStamp { get => _dateStamp; }

    public WithdrawTransaction(Account account, decimal amount) : base(amount)
    {
        _account = account;
    }

    public override void Print()
    {
        Console.WriteLine("The transaction was a " + (_success ? $"sucess. ${_amount}(s) were withdrawn." : "failure"));
    }

    public override void Execute()
    {
        _dateStamp = DateTime.Now;
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

    public override void Rollback()
    {
        _dateStamp = DateTime.Now;
        if (!_executed)
        {
            throw new InvalidOperationException("Withdrawl must have occured before rolling back");
        }
        if (!_success)
        {
            throw new InvalidOperationException("Failed Transactions cannot be rolled back");
        }
        if (_reversed)
        {
            throw new InvalidOperationException("Transaction has already been reversed.");
        }

        _account.Deposit(_amount);
        _reversed = true;
    }
}