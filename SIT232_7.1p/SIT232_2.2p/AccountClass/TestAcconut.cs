class TestAccount
{
    static void Main(string[] args)
    {
        Account account = new Account("Bilbert's Account", 200);

        account.Deposit(2);
        account.Print();

        account.Withdraw(200);
        account.Print();

        Console.WriteLine(account.Name);
    }
}