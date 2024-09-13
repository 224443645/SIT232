class CarProgram
{
    static void Main(string[] args)
    {
        Car car = new Car(2.0);

        car.addFuel(20.0);
        Console.WriteLine(car.getFuel());

        car.drive(3.0);
        Console.WriteLine(car.getTotalMiles());

        car.setTotalMiles(20.5);
        Console.WriteLine(car.getTotalMiles());

        Console.WriteLine(car.calcCost());

        Console.WriteLine(car.convertToLitres(6.0));
    }
}