enum MenuOption
{
    Withdraw,
    Deposit,
    Print,
    Quit
}
class BankSystem
{
    static void Main(string[] args)
    {

        Account testAccount = new Account("David's Savings", 20000);

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
            Console.WriteLine("1. Withdraw\n2. Deposit\n3. Print\n4. Quit");
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
        decimal value = 0;
        do
        {
            Console.WriteLine("Enter the amount you wish to deposit");

            try
            {
                value = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
        } while (!account.Deposit(value));
    }

    static void DoWithdraw(Account account)
    {
        decimal value = 0;
        do
        {
            Console.WriteLine("Enter the amount you wish to withdraw");

            try
            {
                value = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }
        } while (!account.Withdraw(value));
    }

    static void DoPrint(Account account)
    {
        account.Print();
    }
}