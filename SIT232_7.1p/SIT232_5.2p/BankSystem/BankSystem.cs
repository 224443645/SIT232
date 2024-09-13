enum MenuOption
{
    Withdraw,
    Deposit,
    Print,
    Transfer,
    Quit
}
class BankSystem
{
    static void Main(string[] args)
    {

        Account testAccount = new Account("David's Savings", 20000);
        Account charityAccount = new Account("Charity funds", 30000);

        while (true)
        {
            MenuOption userOption = ReadUserOption();
            switch (userOption)
            {
                case MenuOption.Withdraw:
                    Console.WriteLine("Withdraw selected");
                    DoWithdraw(testAccount);
                    break;
                case MenuOption.Deposit:
                    Console.WriteLine("Deposit selected");
                    DoDeposit(testAccount);
                    break;
                case MenuOption.Print:
                    Console.WriteLine("Print selected");
                    DoPrint(testAccount);
                    DoPrint(charityAccount);
                    break;
                case MenuOption.Transfer:
                    Console.WriteLine("Transfer Selected");
                    DoTransfer(testAccount, charityAccount);
                    break;
                case MenuOption.Quit:
                    Console.WriteLine("Quit selected");
                    return;
            }
        }
    }

    static MenuOption ReadUserOption()
    {
        do
        {
            Console.WriteLine("Options: ");
            Console.WriteLine("1. Withdraw\n2. Deposit\n3. Print\n4. Transfer\n5. Quit");
            Console.WriteLine("Select an option by entering the associated number");

            try
            {
                return (MenuOption)(Convert.ToInt32(Console.ReadLine()) - 1);
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }

        } while (true);
    }

    static void DoDeposit(Account account)
    {
        decimal value = -1;
        do
        {
            Console.WriteLine("Enter the amount you wish to deposit");

            try
            {
                value = Convert.ToDecimal(Console.ReadLine());

                if (value <= 0)
                {
                    Console.WriteLine("Invalid input. The deposit amount must be greater than 0.");
                    continue;
                }

            }
            catch
            {
                Console.WriteLine("Input must be a decimal number.");
            }

        } while (value < 0);
        DepositTransaction transaction = new DepositTransaction(account, value);

        transaction.Execute();
        transaction.Print();
    }

    static void DoWithdraw(Account account)
    {
        decimal value = -1;
        do
        {
            Console.WriteLine("Enter the amount you wish to withdraw");

            try
            {
                value = Convert.ToDecimal(Console.ReadLine());

                if (value <= 0)
                {
                    Console.WriteLine("Input must be a valid decimal number greater than 0.");
                    value = -1;
                }
                else if (value > account.Balance)
                {
                    Console.WriteLine($"The amount cannot be greater than the balance ({account.Balance}).");
                    value = -1;
                }
            }
            catch
            {
                Console.WriteLine("Input must be a decimal number.");
            }

        } while (value <= 0 || value > account.Balance);

        WithdrawTransaction transaction = new WithdrawTransaction(account, value);
        transaction.Execute();
        transaction.Print();
    }

    static void DoPrint(Account account)
    {
        account.Print();
    }

    static void DoTransfer(Account fromAccount, Account toAccount)
    {
        decimal value = -1;
        do
        {
            Console.WriteLine("Enter the amount you wish to transfer");

            try
            {
                value = Convert.ToDecimal(Console.ReadLine());

                if (value <= 0)
                {
                    Console.WriteLine("Input must be a valid decimal number greater than 0.");
                    value = -1;
                }
                else if (value > fromAccount.Balance)
                {
                    Console.WriteLine($"The amount cannot be greater than the balance ({fromAccount.Balance}).");
                    value = -1;
                }
            }
            catch
            {
                Console.WriteLine("Input must be a decimal number.");
            }

        } while (value <= 0 || value > fromAccount.Balance);

        new TransferTransaction(fromAccount, toAccount, value).Execute();
    }
}