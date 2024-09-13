class SwitchStatement
{
    static void Main(string[] args)
    {
        int number = 0;

        Console.WriteLine("Enter a number (as an integer): ");
        try
        {
            number = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Input was not an integer");
        }

        switch (number)
        {
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            default: Console.WriteLine("Number not between 1 and 9"); break;
        }
    }
}

int number = 50;
if (number == 50) ; {
    Console.WriteLine(“Number is 50”);
}