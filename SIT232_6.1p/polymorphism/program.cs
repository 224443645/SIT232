class Program 
{
    static void Main(string[] args)
    {
        List<Bird> birds = new List<Bird>();
        Bird bird1 = new Bird();
        Bird bird2 = new Bird();

        bird1.name = "Deathers";
        bird2.name = "Polly";

        Console.WriteLine(bird1.ToString());
        bird1.fly();

        Console.WriteLine(bird2.ToString());
        bird2.fly();

        Penguin penguin1 = new Penguin();
        Penguin penguin2 = new Penguin();

        penguin1.name = "Happy Feet";
        penguin2.name = "Gloria";

        Console.WriteLine(penguin1.ToString());
        penguin1.fly();

        Console.WriteLine(penguin2.ToString());
        penguin2.fly();

        Duck duck1 = new Duck();
        Duck duck2 = new Duck();

        duck1.name = "Daffy";
        duck1.size = 15;
        duck1.kind = "Mallard";

        duck2.name = "Donald";
        duck2.size = 20;
        duck2.kind = "Decoy";

        Console.WriteLine(duck1.ToString());
        Console.WriteLine(duck2.ToString());

        birds.Add(bird1);
        birds.Add(bird2);
        birds.Add(penguin1);
        birds.Add(penguin2);
        List<Duck> ducksToAdd = new List<Duck>()
        {
            duck1,
            duck2,
        };
        IEnumerable<Bird> upcastDucks = ducksToAdd;
        birds.AddRange(upcastDucks);


        birds.Add(new Bird { name = "Birdy" });

        foreach (Bird bird in birds)
        {
            Console.WriteLine(bird);
        }

    }
}