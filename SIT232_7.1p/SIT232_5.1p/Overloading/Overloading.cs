class Overloading
{
    static void Main(string[] args)
    {
        methodToBeOverloaded("Billy");
        methodToBeOverloaded("Billy", 16);
    }

    public static void methodToBeOverloaded(string name)
    {
        Console.WriteLine("Name: " + name);
    }

    public static void methodToBeOverloaded(string name, int age)
    {
        Console.WriteLine("Name: " + name + "\nAge: " + age);
    }
}
