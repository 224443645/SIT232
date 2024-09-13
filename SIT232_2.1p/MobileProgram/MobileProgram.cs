class MobileProgram
{
    static void Main(string[] args)
    {
        Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");
        Console.WriteLine("Account Type: " + jimMobile.getAccType());
        Console.WriteLine("Mobile Number: " + jimMobile.getNumber());
        Console.WriteLine("Device: " + jimMobile.getDevice());
        Console.WriteLine("Balance: " + jimMobile.getBalance());

        jimMobile.setAccType("PAYG");
        jimMobile.setDevice("iPhone 6s");
        jimMobile.setNumber("07713334466");
        jimMobile.setbalance(15.5);

        Console.WriteLine();
        Console.WriteLine("Account Type: " + jimMobile.getAccType());
        Console.WriteLine("Mobile Number: " + jimMobile.getNumber());
        Console.WriteLine("Device: " + jimMobile.getDevice());
        Console.WriteLine("Balance: " + jimMobile.getBalance());

        Console.WriteLine();
        jimMobile.addCredit(10.0);
        jimMobile.makeCall(5);
        jimMobile.sendText(2);

        Mobile billMobile = new Mobile("PAYG", "The x Pro flip max 12 se x5 15 phone of phones", "12835076234");
        Console.Write();
        billMobile.addCredit(12.2);
        billMobile.makeCall(2);
        billMobile.sendText(4);
    }
}


