namespace Lessons.Lesson8;


// II Наследование

public class Animal
{
    private string _name;
    public Animal(string name)
    {
        _name = name;
    }

    public string Name { get; set; }
    public void Eat()
    {
        Console.WriteLine("Я ем пищу");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Животное издаёт звук");
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
        Console.WriteLine("Гав-гав");
    }
}

// base и sealed
public class Cat : Animal
{
    private string _honney;
    public Cat(string name, string honney) : base(name)
    {
        _honney = honney;
    }

    public string Honney { get; set; }

    public void Mew()
    {
        Console.WriteLine("Мяу!");
    }
}