class Bank
{
    private List<Account> _accounts = new List<Account>();

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

    public void ExecuteTransaction(DepositTransaction transaction)
    {
        transaction.Execute();
    }

    public void ExecuteTransaction(WithdrawTransaction transaction)
    {
        transaction.Execute();
    }

    public void ExecuteTransaction(TransferTransaction transaction)
    {
        transaction.Execute();
    }
}