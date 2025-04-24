namespace Lessons.Lesson8;

public class Interfaces
{

}

public interface IMovable
{
    void Move();
    bool IsHaveMove();
    double GetNumber();
}

class Car : IMovable, IComparable
{
    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public double GetNumber()
    {
        throw new NotImplementedException();
    }

    public bool IsHaveMove()
    {
        throw new NotImplementedException();
    }

    public void Move()
    {
        Console.WriteLine("Машина едет.");
    }
}
