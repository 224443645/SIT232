class EmployeeProgram
{
    static void Main(string[] args)
    {
        Employee bob = new Employee("Bob", 60000.0);

        Console.WriteLine("Name: " + bob.getName());

        Console.WriteLine("Salary: " + bob.getSalary());

        Console.WriteLine("Tax: " + bob.Tax());

        bob.setSalary(180000.0);
        Console.WriteLine("Salary: " + bob.getSalary());
        Console.WriteLine("Tax: " + bob.Tax());

    }
}