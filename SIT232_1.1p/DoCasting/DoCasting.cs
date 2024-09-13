class DoCasting
{
    static void Main(string[] args)
    {
        var sum = 17;
        var count = 5;
        var intAverage = 0;

        intAverage = sum / count;
        Console.WriteLine($"IntAverage: {intAverage}");

        var doubleAverage = 0.0;

        doubleAverage = sum / count;
        Console.WriteLine($"doubleAverage no cast: {doubleAverage}");

        doubleAverage = (double)sum / count;
        Console.WriteLine($"doubleAverage do cast: {doubleAverage}");
    }

}
