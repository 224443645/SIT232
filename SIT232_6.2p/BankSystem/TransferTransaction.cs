class TransferTransaction
{
    private Account _fromAccount;
    private Account _toAccount;
    private decimal _amount;
    private DepositTransaction _deposit;
    private WithdrawTransaction _withdraw;
    private bool _executed;
    private bool _reversed;

    public bool Executed { get => _executed; }
    public bool Success { get => _deposit.Success && _withdraw.Success; }
    public bool Reversed { get => _reversed; }

    public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
    {
        this._fromAccount = fromAccount;
        this._toAccount = toAccount;
        this._amount = amount;
        this._deposit = new DepositTransaction(_toAccount, _amount);
        this._withdraw = new WithdrawTransaction(_fromAccount, _amount);
    }

    public void Print()
    {
        Console.WriteLine($"Transfered ${_amount} from {_fromAccount} to {_toAccount}");
        _withdraw.Print();
        _deposit.Print();
    }

    public void Execute()
    {
        if (_executed)
        {
            throw new InvalidOperationException("Transfer has already occured");
        }
        _executed = true;

        _withdraw.Execute();
        _deposit.Execute();

    }

    public void Rollback()
    {
        if (!_executed)
        {
            throw new InvalidOperationException("Transaction has not been executed");
        }
        if (_reversed)
        {
            throw new InvalidOperationException("Transaction has already been rolled back");
        }

        new WithdrawTransaction(_toAccount, _amount).Execute();
        new DepositTransaction(_fromAccount, _amount).Execute();
        _reversed = true;

    }

}