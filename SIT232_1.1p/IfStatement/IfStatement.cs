public static class IfStatement
{
    static void Main(string[] args)
    {
        int number = 0;
        Console.WriteLine("Enter the number (as an integer): ");

        try
        {
            number = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Invalid Input");
        }
        
        if (number == 1)
        {
            Console.WriteLine("ONE");
        }
        else if (number == 2)
        {
            Console.WriteLine("TWO");
        }
        else if (number == 3)
        {
            Console.WriteLine("THREE");
        }
        else if (number == 4)
        {
            Console.WriteLine("FOUR");
        }
        else if (number == 5)
        {
            Console.WriteLine("FIVE");
        }
        else if (number == 6)
        {
            Console.WriteLine("SIX");
        }
        else if (number == 7)
        {
            Console.WriteLine("SEVEN");
        }
        else if (number == 8)
        {
            Console.WriteLine("Eight");
        }
        else if (number == 9)
        {
            Console.WriteLine("NINE");
        }
    }

}