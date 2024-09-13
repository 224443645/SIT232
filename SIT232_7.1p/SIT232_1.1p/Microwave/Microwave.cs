class Microwave
{
    static void Main(string[] args)
    {
        var items = 0;
        var cookTime = 0;

        items = ReadInt("Enter the number of items you wish to cook (in integer form) ");
        cookTime = ReadInt("Enter the amount of time it takes to cook one item in seconds (enter in integer form) ");

        Console.WriteLine($"It is recomended you heat your {items} items for {cookTime + (0.5 * cookTime * (items - 1))} seconds");
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
                success = int.TryParse(Console.ReadLine(), out number);
            }
            catch
            {
                Console.WriteLine("Input was not of type int");
            }
        } while (!success);
        return number;
    }

}
