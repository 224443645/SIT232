abstract public class Animal
{
    abstract public void Greeting();
}
public class Cat : Animal
{
    override public void Greeting()
    {
        Console.WriteLine("Cat: Meow!");
    }
}
public class Dog : Animal
{
    override public void Greeting()
    {
        Console.WriteLine("Dog: Woof!");
    }
    public void Greeting(Dog another)
    {
        Console.WriteLine("Dog: Woooooooooof!");
    }
}
public class BigDog : Dog
{
    override public void Greeting()
    {
        Console.WriteLine("BigDog: Woow!");
    }
    new public void Greeting(Dog another)
    {
        Console.WriteLine("Woooooowwwww!");
    }
}

public class TestAnimal
{
    public static void Main(String[] args)
    {
        // Using the subclasses
        Cat cat1 = new Cat();
        cat1.Greeting(); // greeting method does not exist, should be Greeting
        Dog dog1 = new Dog();
        dog1.Greeting(); // greeting method does not exist, should be Greeting
        BigDog bigDog1 = new BigDog();
        bigDog1.Greeting(); // greeting method does not exist, should be Greeting
        // Using Polymorphism
        Animal animal1 = new Cat();
        animal1.Greeting(); // greeting method does not exist, should be Greeting
        Animal animal2 = new Dog();
        animal2.Greeting(); // greeting method does not exist, should be Greeting
        Animal animal3 = new BigDog();
        animal3.Greeting(); // greeting method does not exist, should be Greeting
        // Downcast
        Dog dog2 = (Dog)animal2;
        BigDog bigDog2 = (BigDog)animal3;
        Dog dog3 = (Dog)animal3;
        Cat cat2 = (Cat)animal2; // dog cannot be cast to cat
        dog2.Greeting(dog3); // greeting method odes not exist, should be Greeting
        dog3.Greeting(dog2); // greeting method odes not exist, should be Greeting
        dog2.Greeting(bigDog2); // greeting method odes not exist, should be Greeting
        bigDog2.Greeting(dog2); // greeting method odes not exist, should be Greeting
        bigDog2.Greeting(bigDog1); // greeting method odes not exist, should be Greeting
    }
}