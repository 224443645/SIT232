namespace Zoo
{
    class Penguin : Bird
    {
        public Penguin(String name, String diet, String location, double weight, int age, String color, String species, double wingspan) : base(name, diet, location, weight, age, color, species, wingspan)
        {

        }

        public override void fly()
        {
            Console.WriteLine("Penguins can't fly");
        }
    }
}