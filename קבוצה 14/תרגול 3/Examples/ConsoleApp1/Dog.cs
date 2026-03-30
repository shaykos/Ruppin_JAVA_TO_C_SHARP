using System;

namespace ConsoleApp1;

public class Dog
{
    // Fields
    private string name;
    private int age;
    private string breed;

    // Constructor
    public Dog(string name, int age, string breed)
    {
        this.name = name;
        this.age = age;
        this.breed = breed;
    }

    // Methods
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Breed: {breed}");
    }

}
