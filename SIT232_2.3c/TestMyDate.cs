class TestMyDate
{

    static void Main()
    {
        MyDate date = new MyDate(12, 8, 2024);
        Console.WriteLine(date.ToString());

        date.SetYear(2023);
        Console.WriteLine(date.ToString());

        date.SetMonth(2);
        Console.WriteLine(date.ToString());

        date.SetDay(2);
        Console.WriteLine(date.ToString());

        date.SetDate(31, 8, 2025);
        Console.WriteLine(date.ToString());

        Console.WriteLine(date.GetYear());
        Console.WriteLine(date.GetMonth());
        Console.WriteLine(date.GetDay());

        date.NextDay();
        Console.WriteLine(date.ToString());

        date.PreviousDay();
        Console.WriteLine(date.ToString());

        date.NextMonth();
        Console.WriteLine(date.ToString());

        date.PreviousMonth();
        Console.WriteLine(date.ToString());

        date.NextYear();
        Console.WriteLine(date.ToString());

        date.PreviousYear();
        Console.WriteLine(date.ToString());

        Console.WriteLine("Leap Years");
        for (int i = 2000; i < 2021; i++)
        {
            Console.WriteLine(i + ". " + date.IsLeapYear(i));
        }

        Console.WriteLine(date.IsValidDate(2, 6, 36));
        Console.WriteLine(date.IsValidDate(2, 6, 3));
    }
}