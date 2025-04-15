// Кортежи или tuples

var text = Test.GetAnyone();

var tuples = Test.GetAnyone2();

int number = tuples.A;
string text2 = tuples.Text;
List<string> listNames = tuples.Names;

var (_, A, _, _) = Test.GetAnyone2();

int number2 = A;

var tuple3 = new Tuple<int, string, List<string>>(1, "", new List<string>());

// Linq

(List<string> Imena, List<int> Ages) tuple4 =
    (
        ["Галя", "Надя", "Вадя"], 
        [75, 13, 45]
    );

Console.WriteLine(string.Join(", ", tuple4.Imena));

//Console.WriteLine($"{tuple4.Imena[0]} : {tuple4.Ages[0]}");

(List<string> Imena, List<int> Ages) tupleResult = new([], []);
for (int i = 0; i < tuple4.Imena.Count; i++)
{
    if (tuple4.Ages[i] < 65)
    {
        tupleResult.Imena!.Add(tuple4.Imena[i]);
        tupleResult.Ages!.Add(tuple4.Ages[i]);
    }    
}

for (int i = 0; i < tupleResult.Imena!.Count; i++)
    Console.WriteLine($"{tupleResult!.Imena[i]} : {tupleResult.Ages[i]}");



var test141 = tuple4.Ages.Where(x => x < 65).ToList();



/* 
 * 
 Напишите программу, которая:

    Создает кортежи для представления информации о геометрических фигурах (круг, прямоугольник, треугольник)

    Вычисляет периметр и площадь каждой фигуры

    Сравнивает фигуры по площади

 */
string text9 = string.Empty;
Circle circle = new(23.4);
Rectangle rectangle = new(5.2, 3.1);

bool isEqual = circle.Square == rectangle.Square;
bool isEqual2 = circle.Perimeter == rectangle.Perimeter;

if (isEqual)
    text9 = $"Площать круга: {circle.Square} равна площади прямоугольника: {rectangle.Square}\n" +
        $"Периметр круга: {circle.Perimeter} равна периметру прямоугольника: {rectangle.Perimeter}";
else
    text9 = $"Площать круга: {circle.Square} не равна площади прямоугольника: {rectangle.Square}\n" +
        $"Периметр круга: {circle.Perimeter} не равна периметру прямоугольника: {rectangle.Perimeter}";

Console.WriteLine(text9);
Console.WriteLine();


public class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double Radius
    {
        get
        {
            return _radius;
        }
        set
        {
            _radius = value;
        }
    }

    public double Square
    {
        get
        {
            double square = Math.Sqrt(_radius) * Math.PI;
            return square;
        }
    }

    public double Perimeter
    {
        get
        {
            return 2 * Math.PI * _radius;
        }
    }
}

public class Rectangle
{
    private double _x;
    private double _y;

    public Rectangle(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public double X
    {
        get
        {
            return _x;
        }
        set
        {
            _x = value;
        }
    }

    public double Y
    {
        get
        {
            return _y;
        }
        set
        {
            _y = value;
        }
    }

    public double Square
    {
        get
        {
            return _x * _y;
        }
    }

    public double Perimeter
    {
        get
        {
            return (_x + _y) * 2; 
        }
    }
}
















public static class Test
{
    public static string GetAnyone()
    {
        string test = "Как?";

        return test;
    }

    public static (string Text, int A, bool IsHaveText, List<string> Names) GetAnyone2()
    {
        string text = "ТАк!";
        int a = 14124;
        bool isHaveText = true;
        List<string> names = ["Галя", "Вадя"];

        (string Text, int A, bool IsHaveText, List<string> Names) result = (text, a, isHaveText, names);

        return result;
    }
}


