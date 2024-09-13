class Mobile
{
    // instance variables
    private String accType, device, number;
    private double balance;

    // VARABIBLES
    private const double CALL_COST = 0.245;
    private const double TEXT_COST = 0.078;

    // constructor
    public Mobile(String accType, string device, String number)
    {
        this.accType = accType;
        this.device = device;
        this.number = number;
        this.balance = 0.0;
    }

    // Accessor / getter
    public String getAccType()
    {
        return this.accType;
    }

    public String getDevice()
    {
        return this.device;
    }

    public String getNumber()
    {
        return this.number;
    }

    public String getBalance()
    {
        return this.balance.ToString("C");
    }

    // setters
    public void setAccType(String accType)
    {
        this.accType = accType;
    }

    public void setDevice(String device)
    {
        this.device = device;
    }

    public void setNumber(String number)
    {
        this.number = number;
    }

    public void setbalance(double balance)
    {
        this.balance = balance;
    }

    // methods
    public void addCredit(double credit)
    {
        this.balance += credit;
        Console.WriteLine("Credit added successfully. New balance " + getBalance());
    }

    public void makeCall(int minutes)
    {
        double cost = minutes * CALL_COST;
        this.balance -= cost;
        Console.WriteLine("Text Sent. New balance " + getBalance());
    }

    public void sendText(int numTexts)
    {
        double cost = numTexts * TEXT_COST;
        this.balance -= cost;
        Console.WriteLine("Text Sent. New balance " + getBalance());
    }

}

