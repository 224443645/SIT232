class GuessingNumber
{
    static void Main(string[] args)
    {
        var user2Target = 0;
        var user2Guess = 0;

        while (true)
        {
            user2Target = ReadIntRange("User 1 set a target for user2 between 1 and 10", 1, 10);
            user2Guess = ReadIntRange("User 2 guess a number between 1 and 10", 1, 10);

            if (user2Target == user2Guess)
            {
                Console.WriteLine("You guessed correct!");
                break;
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

    static int ReadIntRange(string message, int min, int max)
    {
        var number = 0;
        var success = false;
        while (!success)
        {
            number = ReadInt(message);
            if (number >= min && number <= max)
            {
                success = true;
            }
            else
            {
                Console.WriteLine("Input out of range");
            }
        }

        return number;
    }

}
