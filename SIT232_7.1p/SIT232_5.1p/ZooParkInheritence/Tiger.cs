namespace Zoo
{
    class Tiger : Feline
    {
        private String colorStripes;
        public Tiger(String name, String diet, String location, double weight, int age, String color, String species, String colorStripes) : base(name, diet, location, weight, age, color, colorStripes)
        {
            this.colorStripes = colorStripes;
        }

        public override void makeNoise()
        {
            Console.WriteLine("Roar");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 9kgs of meat");
        }

        public override void dance()
        {
            Console.WriteLine("Does a tiger dance");
        }
    }
}