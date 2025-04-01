using System;

public class Animal
{
    public virtual void makeSound() // เมทอด virtual ที่สามารถ override ได้
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void makeSound() // Override เมทอด makeSound ของ Animal
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void makeSound() // Override เมทอด makeSound ของ Animal
    {
        Console.WriteLine("Cat meows");
    }
}

public class AnimalSound
{
    public void PlaySound(Animal animal) // ใช้ polymorphism ในการรับประเภท Animal
    {
        animal.makeSound(); // เรียกเมทอด makeSound
    }
}

class Program
{
    static void Main()
    {
        AnimalSound sound = new AnimalSound(); // สร้างอ็อบเจ็กต์ AnimalSound
        Animal dog = new Dog(); // สร้างอ็อบเจ็กต์ Dog
        Animal cat = new Cat(); // สร้างอ็อบเจ็กต์ Cat

        sound.PlaySound(dog); // เรียกเสียงของสุนัข
        sound.PlaySound(cat); // เรียกเสียงของแมว
    }
}

