class Repition
{
    static void Main(string[] args)
    {



        int sum = 0;
        double average;
        int upperbound = 100;

        for (int i = 1; i <= upperbound; i++)
        {
            sum += i;
        }

        // int sum = 0;
        // double average;
        // int upperbound = 100;

        // int i = 1;
        // do
        // {
        //     sum += i;
        //     i++;
        // } while (i <= upperbound);


        // int sum = 0;
        // double average;
        // int upperbound = 100;

        // int i = 1;
        // while (i <= upperbound)
        // {
        //     sum += i;
        //     i++;
        // }

        average = (double)sum / upperbound;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
    }

}