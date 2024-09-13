namespace Zoo
{
    class Eagle : Bird
    {
        
        public Eagle(String name, String diet, String location, double weight, int age, String color, String species, double wingspan) : base(name, diet, location, weight, age, color, species, wingspan)
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Eagle, Eagle"); // Pretty sure this would be the pokedex entry
        }

        public override void eat() {
            Console.WriteLine("I eat half a kilo of fish");
        }

        public override void dance() {
            Console.WriteLine("Does an eagle dance");
        }
    }
}