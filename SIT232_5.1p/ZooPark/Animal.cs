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

    public void eat() { }
    public void sleep() { }
    public void makeNoise() { }

    public void makeLionNoise() {}
    public void makeEagleNois(){}
    public void makeWolfNoise() {}

    public void eatMeat() {}
    public void eatBerries() {}
}