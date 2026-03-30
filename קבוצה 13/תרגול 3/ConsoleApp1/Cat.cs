using System;

namespace ConsoleApp1;

public class Cat
{
    #region fields

    private string name;
    private int age;
    private string color;

    #endregion

    #region constructors

    public Cat(string name, int age, string color)
    {
        this.name = name;
        this.age = age;
        this.color = color;
    }

    #endregion

    #region methods

    public void Meow()
    {
        Console.WriteLine("Meow!");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Color: {color}");
    }

    

    #endregion
}
