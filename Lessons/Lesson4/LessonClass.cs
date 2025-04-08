namespace Lessons.Lesson4;

public class LessonClass
{
    // Поля
    // Свойства
    // Методы
    // Контсрукторы

}

public class Fruit
{
    // Поля
    private string _color;
    private int _count;
    private string _name;

    // Конструктор 
    public Fruit(string color, int count, string name)
    {
        _color = color;
        _count = count;
        _name = name;
    }

    // Свойства
    public string Color 
    {
        get
        {
            return _color;
        }
        set
        {
            _color = value;
        }
    }

    public int Count { get; set; }

    public string Name { get; set; }

    public string[] GetFruit()
    {
        string[] fruit = [Color, Count.ToString(), Name];
        return fruit;
    }


}
