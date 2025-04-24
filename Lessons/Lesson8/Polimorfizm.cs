namespace Lessons.Lesson8;

public class Polimorfizm : Cat
{
    public Polimorfizm(string name, string honney) : base(name, honney)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Котик издаёт мурлыканье");
    }

    public void Polimorfizm_test()
    {
        MakeSound();
    }
}


