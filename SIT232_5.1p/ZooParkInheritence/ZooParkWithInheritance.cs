namespace Zoo
{
    class ZooPark
    {
        static void Main(string[] args)
        {
            // Animal williamWolf = new Animal("Willian the World", "Meat", "Dog village", 50.6, 9, "Grey");
            // Animal tonyTiger = new Animal("Tony the tiger", "Meat", "Cate Land", 110, 6, "Orange and black");
            // Animal edgarEagle = new Animal("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black");

            Tiger tonyTiger = new Tiger("Tony the tiger", "Meat", "Cate Land", 110, 6, "Orange and black", "Siberian", "White");
            Wolf williamWolf = new Wolf("Willian the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Balck", "Harpy", 98.5);
            Lion lancasterLion = new Lion("Lancaster the Lion", "Meat", "Lancaster", 12, 6, "Lion Color", "Simba");
            Penguin portonPenguin = new Penguin("Porton the Penguin", "Fish", "Antartica", 24.4, 2, "Black and white", "Arctic", 20.3);


            tonyTiger.makeNoise();
            williamWolf.makeNoise();
            edgarEagle.makeNoise();
            lancasterLion.makeNoise();
            portonPenguin.makeNoise();


            var baseAnimal = new Animal("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Color");
            baseAnimal.makeNoise();

            tonyTiger.eat();
            williamWolf.eat();
            edgarEagle.eat();
            lancasterLion.eat();
            portonPenguin.eat();

            tonyTiger.dance();
            williamWolf.dance();
            edgarEagle.dance();
            lancasterLion.dance();
            portonPenguin.dance();

            baseAnimal.sleep();
            tonyTiger.sleep();
            williamWolf.sleep();
            edgarEagle.sleep();
            tonyTiger.eat();

            edgarEagle.fly();
            portonPenguin.fly();
        }
    }
}