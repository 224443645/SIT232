/// <summary>
/// Handles a list of accounts with methods for retrieving them and executing transactions
/// </summary>
class Bank
{
    /// <summary>
    /// List of accounts handled by the bank object
    /// </summary>
    private List<Account> _accounts = new List<Account>();

    /// <summary>
    /// Adds a new account to the bank
    /// </summary>
    /// <param name="newAccount">The new account to be added</param>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public void AddAccount(Account newAccount)
    {
        if (newAccount == null) { throw new ArgumentNullException("Account object cannot be null"); }
        foreach (Account account in _accounts)
        {
            if (account.Name == newAccount.Name) { throw new InvalidOperationException("Account already in bank"); }
        }
        _accounts.Add(newAccount);
    }

    /// <summary>
    /// Returns an account object given the name of the account
    /// </summary>
    /// <param name="name">Name of the account you are getting</param>
    /// <returns>Returns null if no account is found</returns>
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

    /// <summary>
    /// Executes DepositTransaction 
    /// </summary>
    /// <param name="transaction"> DepositTransaction to be executed</param>
    public void ExecuteTransaction(DepositTransaction transaction)
    {
        transaction.Execute();
    }
    /// <summary>
    /// Executes WithdrawTransaction
    /// </summary>
    /// <param name="transaction">WithdrawTransaction to be executed</param>
    public void ExecuteTransaction(WithdrawTransaction transaction)
    {
        transaction.Execute();
    }
    /// <summary>
    /// Executes TransferTransaction
    /// </summary>
    /// <param name="transaction">TransferTransaction to be executed</param>
    public void ExecuteTransaction(TransferTransaction transaction)
    {
        transaction.Execute();
    }
}