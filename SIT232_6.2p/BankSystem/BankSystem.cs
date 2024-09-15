/// <summary>
/// Enum of different menu options the user can choose
/// </summary>
enum MenuOption
{
    Withdraw,
    Deposit,
    Print,
    Transfer,
    AddNewAccount,
    Quit
}
/// <summary>
/// methods and Main method/logic for operating the banksystem
/// </summary>
class BankSystem
{
    /// <summary>
    /// Entry point for the program
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        bank.AddAccount(new Account("David's Savings", 20000));
        bank.AddAccount(new Account("Charity funds", 30000));

        while (true)
        {
            MenuOption userOption = ReadUserOption();
            switch (userOption)
            {
                case MenuOption.Withdraw:
                    Console.WriteLine("Withdraw selected");
                    DoWithdraw(SelectAccount(bank), bank);
                    break;
                case MenuOption.Deposit:
                    Console.WriteLine("Deposit selected");
                    DoDeposit(SelectAccount(bank), bank);
                    break;
                case MenuOption.Print:
                    Console.WriteLine("Print selected");
                    DoPrint(SelectAccount(bank));
                    break;
                case MenuOption.Transfer:
                    Console.WriteLine("Transfer Selected\nSelect From Account then To Account");
                    DoTransfer(SelectAccount(bank), SelectAccount(bank), bank);
                    break;
                case MenuOption.AddNewAccount:
                    Console.WriteLine("Add account selected");
                    DoAddAccount(bank);
                    break;
                case MenuOption.Quit:
                    Console.WriteLine("Quit selected");
                    return;
            }
        }
    }
    /// <summary>
    /// Reads user option
    /// </summary>
    /// <returns>Returns MenuOption</returns>
    static MenuOption ReadUserOption()
    {
        do
        {
            Console.WriteLine("Options: ");
            Console.WriteLine("1. Withdraw\n2. Deposit\n3. Print\n4. Transfer\n5. Add new account\n6. Quit");
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

    /// <summary>
    /// Gets amount the user would like to deposit and executes the transaction 
    /// </summary>
    /// <param name="account">The account to deposit to</param>
    /// <param name="bank">The bank to handle the transaction</param>
    static void DoDeposit(Account account, Bank bank)
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

        bank.ExecuteTransaction(transaction);
        transaction.Print();
    }
    /// <summary>
    /// Gets amount the user would like to withdraw and executes the transaction
    /// </summary>
    /// <param name="account">The account to withdraw from</param>
    /// <param name="bank">The bank to handle the transaction</param>
    static void DoWithdraw(Account account, Bank bank)
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
        bank.ExecuteTransaction(transaction);
        transaction.Print();
    }
    /// <summary>
    /// Prints information about the given account
    /// </summary>
    /// <param name="account">Account to print information of</param>
    static void DoPrint(Account account)
    {
        account.Print();
    }
    /// <summary>
    /// Gets the amount the user would like to transfer between accounts and eecutes transaction
    /// </summary>
    /// <param name="fromAccount">Account to transfer from</param>
    /// <param name="toAccount">Account to transfer to</param>
    /// <param name="bank">Bank to handle the transaction</param>
    static void DoTransfer(Account fromAccount, Account toAccount, Bank bank)
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

        TransferTransaction transaction = new TransferTransaction(fromAccount, toAccount, value);
        bank.ExecuteTransaction(transaction);
        transaction.Print();

    }
    /// <summary>
    /// Gets information about new account and adds it to specified bank
    /// </summary>
    /// <param name="bank">Bank to add tbe account to</param>
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
        try
        {
            bank.AddAccount(new Account(name, value));
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("Account cannot be added to bank because one with the same name already exists");
        }
    }
    /// <summary>
    /// Helper method for allowing the user to select an account
    /// </summary>
    /// <param name="bank">Bank object to select the account from</param>
    /// <returns>Returns an Account object</returns>
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
}