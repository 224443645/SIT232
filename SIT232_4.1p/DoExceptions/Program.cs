class Program
{
    static void Main(string[] args)
    {
        try
        {
            DoNullReferenceException();
        }
        catch (System.NullReferenceException exception)
        {
            Console.WriteLine("The following error detected: " +
                exception.GetType().ToString() + " with message \"" +
                exception.Message + "\"");
        }

        try
        {
            DoIndexOutOfRangeException();
        }
        catch (System.IndexOutOfRangeException exception)
        {
            Console.WriteLine("The following error detected: " +
                exception.GetType().ToString() + " with message \"" +
                exception.Message + "\"");
        }

        // try
        // {
        //     DoStackOverflowException();
        // }
        // catch (System.StackOverflowException exception)
        // {
        //     Console.WriteLine("The following error detected: " +
        //         exception.GetType().ToString() + " with message \"" +
        //         exception.Message + "\"");
        // }

        try
        {
            DoOutOfMemoryException();
        }
        catch (System.OutOfMemoryException exception)
        {
            Console.WriteLine("The following error detected: " +
                exception.GetType().ToString() + " with message \"" +
                exception.Message + "\"");
        }
        try
        {
            DoDivideByZeroException();
        }
        catch (System.DivideByZeroException exception)
        {
            Console.WriteLine("The following error detected: " +
                exception.GetType().ToString() + " with message \"" +
                exception.Message + "\"");
        }

        try
        {
            DoArgumentNullException();
        }
        catch (System.ArgumentNullException exception)
        {
            Console.WriteLine("The following error detected: " +
                exception.GetType().ToString() + " with message \"" +
                exception.Message + "\"");
        }

        try
        {
            DoArgumentOutOfRangeException();
        }
        catch (System.ArgumentOutOfRangeException exception)
        {
            Console.WriteLine("The following error detected: " +
                exception.GetType().ToString() + " with message \"" +
                exception.Message + "\"");
        }

        try
        {
            DoFormatException();
        }
        catch (System.FormatException exception)
        {
            Console.WriteLine("The following error detected: " +
                exception.GetType().ToString() + " with message \"" +
                exception.Message + "\"");
        }

        try
        {
            DoArguemntException();
        }
        catch (System.ArgumentException exception)
        {
            Console.WriteLine("The following error detected: " +
                exception.GetType().ToString() + " with message \"" +
                exception.Message + "\"");
        }
    }

    static void DoNullReferenceException()
    {
        List<String> names = null;
        names.Add("Bill");
    }

    static void DoIndexOutOfRangeException()
    {
        int[] ints = new int[5];

        Console.WriteLine(ints[5]);
    }

    static void DoStackOverflowException()
    {
        DoStackOverflowException();
    }

    static void DoOutOfMemoryException()
    {
        int[] largeArray = new int[int.MaxValue];
    }

    static void DoDivideByZeroException()
    {
        int num1 = 1;
        int num2 = 0;
        int val = num1 / num2;
    }

    static void DoArgumentNullException()
    {
        List<int> ints = new List<int>(null);
    }

    static void DoArgumentOutOfRangeException()
    {
        List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
        int item = ints[10];
    }

    static void DoFormatException()
    {
        int val = int.Parse("Yeah sure no problems here i'm sure this will work just fine");
    }
    static void DoArguemntException()
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();

        dic.Add("Key1", 1);
        dic.Add("Key1", 1);
    }


}