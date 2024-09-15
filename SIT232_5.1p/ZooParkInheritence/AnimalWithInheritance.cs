namespace Zoo
{
    class Animal
    {
        private String name;
        private String diet;
        private String location;
        private double weight;
        private int age;
        private String color;

        public Animal(String name, String diet, String location, double weight, int age, String color)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.color = color;
        }

        public virtual void eat()
        {
            Console.WriteLine("consume.");
        }
        public void sleep()
        {
            Console.WriteLine("Sleeps");
        }
        public virtual void makeNoise()
        {
            Console.WriteLine("An animal makes a noise");
        }

        public virtual void dance()
        {
            Console.WriteLine("An animal does a little jig");
        }
    }
}