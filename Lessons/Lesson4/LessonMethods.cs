namespace Lessons.Lesson4;

public class LessonMethods
{
    // Модификаторы доступы
    // public 
    public void Public() { }

    // private
    private void Private() { }

    // protected
    protected void Protected() { }

    // internal
    internal void Internal() { }

    //-----------------------------||-----------------------------
    //Методы
    // Параметр без методов
    internal void FirstMethod() 
    {
        Console.WriteLine("Я без методов, ребята");
    }

    // Метод с параметрами
    public void MethodWithParameters(int a, string description)
    {
        Console.WriteLine(description + a);
    }

    // Метод с необязательными параметрами
    public void MethodWithNullParameters(int a, string description, string name = "Delta", string name1 = "Test")
    {
        Console.WriteLine(description + a);
        Console.WriteLine(name);
    }

    // Входной параметр out
    public void MethodWithOut(int count, out int b)
    {
        Console.WriteLine("Количетсво: " + count);
        b = 100;
    }

    // Входной параметр ref
    public void MethodWithRef(int count, ref int b) 
    {
        Console.WriteLine();
        b = 10004241;
    }

    // массив параметров params
    public void ParamsMethod(params int[] a)
    {
        Console.WriteLine(string.Join(", ", a));
    }

    //-----------------------------||-----------------------------
    // Перегрузка методов + комментарии

    /// <summary>
    /// Какое то описание
    /// </summary>
    /// <param name="a"></param>
    public void Test1(int a) { Console.WriteLine(a); }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a">Это а тут > 0</param>
    /// <param name="b"></param>
    public void Test1(int a, int b = 0) { Console.WriteLine(a + b); }
    public void Test1() { Console.WriteLine("Ничего нету"); }



    // Expression-bodied
    public void Expression() => Console.WriteLine("Одна строка");
    public void Expression2()
    {
        Console.WriteLine("Одна строка");
    }

    public int Umnozhenie(int x, int y) => x * y;


    // static методы
    public static void TestStatic()
    {
        Console.WriteLine("static");
    }


    // return
    public int GetSumNumber(int[] numbers)
    {
        return numbers.Sum();
    }

    public int GetSumNumber2(int[] numbers) => numbers.Sum();

}

public class TestClass
{
    public void Test()
    {
        int b = 100;
        // Метод без параметров
        LessonMethods lesson4 = new();
        lesson4.FirstMethod();

        // Метод с параметрами
        lesson4.MethodWithParameters(500, description: "описание");
        lesson4.MethodWithNullParameters(500, "описание", name1: "Da");

        //out
        lesson4.MethodWithOut(599, out b);
        Console.WriteLine(b);
        b = 412;

        string number = "15";
        int.Parse(number);
        bool isParse = int.TryParse(number, out int result);

        // ref
        int c = 415;
        lesson4.MethodWithRef(4, ref c);

    }
}
