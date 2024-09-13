class DivisibleFour
{
    static void Main(string[] args)
    {
        int n = ReadInt("Enter a number");
        for (int i = 1; i < n; i++)
        {
            if (i % 4 == 0 && i % 5 > 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    static int ReadInt(string message)
    {
        var number = 0;
        var success = false;
        do
        {
            Console.WriteLine(message);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            catch
            {
                Console.WriteLine("Input was not of type int");
            }
        } while (!success);
        return number;
    }
}