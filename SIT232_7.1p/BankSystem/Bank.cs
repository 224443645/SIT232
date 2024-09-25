class Bank
{
    private List<Account> _accounts = new List<Account>();
    private List<Transaction> _transactions = new List<Transaction>();

    public int AccountsCount {get => _accounts.Count;}

    public void AddAccount(Account account)
    {
        _accounts.Add(account);
    }

    public Account GetAccount(String name)
    {
        foreach (Account account in _accounts)
        {
            if (account.Name == name)
            {
                return account;
            }
        }

        return null;
    }

    public void ExecuteTransaction(Transaction transaction)
    {
        _transactions.Add(transaction);
        transaction.Execute();
    }

    public void RollbackTransaction(Transaction transaction)
    {
        transaction.Rollback();
    }

    public void PrintTransactionHistory()
    {
        int i = 1;
        foreach (Transaction transaction in _transactions)
        {
            Console.Write(i + ". ");
            transaction.Print();
            i++;
        }
    }

    public Transaction GetTransaction(int index)
    {
        if (index >= _transactions.Count || index < 0)
        {
            return null;
        }
        return _transactions[index];
    }
}