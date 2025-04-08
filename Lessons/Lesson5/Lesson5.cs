namespace Lessons.Lesson5;

public class Lesson5
{
    public void Lesson_5()
    {
        // псевдоним
        //using kavo = System.Console;

        // генератор
        Random rnd = new();

        var test = rnd.Next(0, 101);

        string pass = "GDFPSDF@51312";

        //---------------------------||-------------------------

        // Как понять что число простое?
        int simpleNumber = 17;


        //  Вычислите сумму всех чисел от 1 до N, где N вводит пользователь.

        Console.WriteLine("Введи число");
        string getNumber = Console.ReadLine()!;

        if (string.IsNullOrEmpty(getNumber))
            Console.WriteLine("Ошибка, не передано число");

        bool isParse = int.TryParse(getNumber, out int result);
        long sum = 0;

        if (!isParse)
            Console.WriteLine("Введено некорректное число");
        else
        {
            for (int i = 1; i <= result; i++)
                sum = sum + i;
        }


        Console.WriteLine("Сумма: " + sum);

        Console.WriteLine();

        //-------------------------------||-------------------------------

        int a = 15;
        int b = 10;
        int c;

        if (a > b)
            c = a;
        else
            c = b;

        int d = a > b ? a : b;
        // условие ? если true : если false
    }
}
