using System;

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
        Console.WriteLine($"Animal Constructor: {Name}");
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
        Console.WriteLine($"Dog Constructor: {Name}, {Breed}");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Buddy", "Golden Retriever");
    }
}

