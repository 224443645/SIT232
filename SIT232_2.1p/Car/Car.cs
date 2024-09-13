class Car
{
    private double fuelEfficency;
    private double fuel;
    private double milesDriven;

    private double FUEL_COST = 1.385;

    public Car(double fuelEfficency)
    {
        this.fuelEfficency = fuelEfficency;
        this.fuel = 0;
        this.milesDriven = 0;
    }

    public double getFuel()
    {
        return this.fuel;
    }

    public double getTotalMiles()
    {
        return this.milesDriven;
    }

    public void setTotalMiles(double totalMiles)
    {
        this.milesDriven = totalMiles;
    }

    public void printFuelCost()
    {
        Console.WriteLine(this.FUEL_COST);
    }

    public void addFuel(double fuel)
    {
        this.fuel += fuel;
        Console.WriteLine($"The fuel cost ${fuel * FUEL_COST}");
    }

    public double calcCost()
    {
        return this.fuel * this.FUEL_COST;
    }

    public double convertToLitres(double gallons)
    {
        return gallons * 4.546;
    }

    public void drive(double miles)
    {
        milesDriven += miles;
        double fuelUsed = convertToLitres(miles / fuelEfficency); 

        // the task sheet doesn't say to update the amount of fuel in the car but im assuming that we are meant
        // to do so since driving the vehicle would consume fuel
        fuel -= fuelUsed;

        Console.WriteLine($"The drive cost ${fuelUsed*FUEL_COST}");
    }

}