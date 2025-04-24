namespace Lessons.Lesson8;

public class Abstract
{

}

public abstract class Shape
{
    public string Name { get; set; }

    public abstract double GetArea();

    public void SimpleMethod()
    {
        Console.WriteLine("Я обычный");
    }
}

public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Sqrt(_radius);
    }
}

