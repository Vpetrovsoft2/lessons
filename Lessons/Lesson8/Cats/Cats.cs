using Lessons.Lesson8.Cats.Interfaces;

namespace Lessons.Lesson8.Cats;

public abstract class Cats
{
    private string _name;
    private string _coatColor;
    private int _age;

    public Cats(string name, string coatColor, int age)
    {
        _name = name;
        _coatColor = coatColor;
        _age = age;
    }

    #region PROPERTIES
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public string CoatColor
    {
        get
        {
            return _coatColor;
        }
        set
        {
            _coatColor = value;
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }
    #endregion

    public abstract void GetCoatColor();

    public virtual void WhatCatIsLove() => Console.WriteLine($"{Name} - любит рыбу");
}

public class SphynxCat : Cats
{
    public SphynxCat(string name, string coatColor, int age) : base(name, coatColor, age)
    {
    }

    public override void GetCoatColor()
    {
        Console.WriteLine($"{Name} - сфинкс, у него нету шерсти");
    }

    public override void WhatCatIsLove()
    {
        Console.WriteLine($"{Name} - любит корм");
    }
}

public class DeadCat : Cats, ICatIsDead
{
    public DeadCat(string name, string coatColor, int age) : base(name, coatColor, age)
    {
    }

    public override void GetCoatColor()
    {
        Console.WriteLine($"{Name} - умер, цвет шерсти неизвестен");
    }

    public void WhenCatIdDead()
    {
        Console.WriteLine($"{Name} - умер {DateTime.Now.AddYears(-1):yyyy-MM-dd}");
    }

    public override void WhatCatIsLove()
    {
        Console.WriteLine($"{Name} - умер, он больше ничего не любит");
    }
}

public class SimpleCat : Cats
{
    public SimpleCat(string name, string coatColor, int age) : base(name, coatColor, age)
    {
    }

    public override void GetCoatColor()
    {
        Console.WriteLine($"{Name} имеет {CoatColor} цвет шерсти");
    }
}