namespace Zoo
{
    class Wolf : Animal
    {
        public Wolf(String name, String diet, String location, double weight, int age, String color) : base(name, diet, location, weight, age, color) { }

        public override void makeNoise()
        {
            Console.WriteLine("Bark");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 5kgs of meat");
        }

        public override void dance() {
            Console.WriteLine("Does a wolf dance");
        }
    }
}