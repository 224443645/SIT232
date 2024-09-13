abstract class Transaction
{
    protected decimal _amount;
    protected bool _success;
    private bool _executed;
    private bool _reversed;
    private DateTime _dateStamp;

    public bool Success { get => _success; }
    public bool Executed { get => _executed; }
    public bool Reveresed { get => _reversed; }
    public DateTime DateStamp { get => _dateStamp; }

    public Transaction(decimal amount)
    {
        _amount = amount;
    }

    public virtual void Print()
    {

    }

    public virtual void Execute()
    {
        _dateStamp = DateTime.Now;
    }

    public virtual void Rollback()
    {
        _dateStamp = DateTime.Now;
    }
}