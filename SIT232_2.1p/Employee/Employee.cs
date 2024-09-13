class Employee
{
    private string name;
    private double salary;
    public Employee(string name, double salary)
    {
        this.name = name;
        if (salary < 0) { throw new ArgumentOutOfRangeException("Salary cannot be less than 0"); }
        this.salary = salary;
    }

    public string getName()
    {
        return this.name;
    }

    public string getSalary()
    {
        return "$" + Convert.ToString(this.salary);
    }

    public void raiseSalary(double raise)
    {
        this.salary *= 1 + (raise / 100);
        if (this.salary < 0) { this.salary = 0; }
    }

    public void setSalary(double salary)
    {
        if (salary < 0) { throw new ArgumentOutOfRangeException("Salary cannot be less than 0"); }
        this.salary = salary;
    }

    public double Tax()
    {
        double tax = 0.0;
        if (this.salary <= 18200)
        {
            // no tax
        }
        if (this.salary <= 37000)
        {
            tax = (this.salary - 18200) * 0.19;
        }
        if (this.salary <= 90000)
        {
            tax = 3572 + (this.salary - 37000) * 0.325;
        }
        if (this.salary <= 180000)
        {
            tax = 20797 + (this.salary - 90000) * 0.37;
        }
        else
        {
            tax = 54096 + (this.salary - 180000) * 0.45;
        }
        return tax;
    }
}