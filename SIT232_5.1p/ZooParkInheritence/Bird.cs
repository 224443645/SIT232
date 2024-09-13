namespace Zoo
{
    class Bird : Animal
    {
        private string species;
        private double wingspan;
        public Bird(String name, String diet, String location, double weight, int age, String color, String species, double wingspan) : base(name, diet, location, weight, age, color)
        {
            this.species = species;
            this.wingspan = wingspan;
        }

        public void layEgg() { }
        public virtual void fly() { }
    }
}