enum MenuOption
{
    Withdraw,
    Deposit,
    Print,
    Transfer,
    AddNewAccount,
    PrintTransactionHistory,
    Quit
}
class BankSystem
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        bank.AddAccount(new Account("David", 20000));
        bank.AddAccount(new Account("Charity", 30000));

        while (true)
        {
            MenuOption userOption = ReadUserOption();
            switch (userOption)
            {
                case MenuOption.Withdraw:
                    Console.WriteLine("Withdraw selected");
                    DoWithdraw(SelectAccount(bank));
                    break;
                case MenuOption.Deposit:
                    Console.WriteLine("Deposit selected");
                    DoDeposit(SelectAccount(bank));
                    break;
                case MenuOption.Print:
                    Console.WriteLine("Print selected");
                    DoPrint(SelectAccount(bank));
                    break;
                case MenuOption.Transfer:
                    Console.WriteLine("Transfer Selected\nSelect From Account then To Account");
                    DoTransfer(SelectAccount(bank), SelectAccount(bank));
                    break;
                case MenuOption.AddNewAccount:
                    Console.WriteLine("Add account selected");
                    DoAddAccount(bank);
                    break;
                case MenuOption.PrintTransactionHistory:
                    Console.WriteLine("Transaction History Selected");
                    DoPrintTransactionHistory(bank);
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
            Console.WriteLine("1. Withdraw\n2. Deposit\n3. Print\n4. Transfer\n5. Add new account\n6. Print transaction history\n7. Quit");
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

    static void DoAddAccount(Bank bank)
    {
        Console.WriteLine("Enter the name of the new account");
        String name;
        do
        {
            name = Console.ReadLine();
        } while (name == null);
        decimal value = -1;
        do
        {
            Console.WriteLine("Enter the balance of the new account");
            try
            {
                value = Convert.ToDecimal(Console.ReadLine());

                if (value <= 0)
                {
                    Console.WriteLine("Invalid input. The deposit amount must be greater than 0.");
                    value = -1;
                    continue;
                }
            }
            catch
            {
                Console.WriteLine("Input must be a decimal number.");
            }
        } while (value == -1);

        bank.AddAccount(new Account(name, value));
    }
    static Account SelectAccount(Bank bank)
    {
        Account account = null;
        String name = " ";

        while (account == null)
        {
            Console.WriteLine("Select an account");
            name = Console.ReadLine();

            account = bank.GetAccount(name);
            if (account == null)
            {
                Console.WriteLine("Account does not exist");
            }
        }

        return account;
    }
    static void DoPrintTransactionHistory(Bank bank)
    {
        bank.PrintTransactionHistory();
        String input = " ";
        bool success = false;
        while (!success)
        {
            Console.WriteLine("Would you like to roll back a transaction. y/n");
            input = Console.ReadLine();
            if (input == "y" || input == "n")
            {
                success = true;
            }
            else
            {
                Console.WriteLine("Must be y or n in lower case");
            }
        }

        if (input == "n")
        {
            return;
        }

        DoRollback(bank);
    }
    static void DoRollback(Bank bank)
    {
        Transaction transaction = null;
        int value = -1;
        do
        {
            Console.WriteLine("Select the transaction you would like to rollback");
            try
            {
                value = Convert.ToInt32(Console.ReadLine());

                if (value <= 0)
                {
                    Console.WriteLine("Input must be a valid int greater than 0");
                    value = -1;
                }

            }
            catch
            {
                Console.WriteLine("Input must be a decimal number.");
            }
            transaction = bank.GetTransaction(value);
        } while (value <= 0 || transaction == null);

        transaction.Rollback();
        Console.WriteLine("Transaction was rolled back");
    }
}