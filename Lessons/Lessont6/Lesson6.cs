namespace Lessons.Lessont6;

public class Lesson6
{
    public void Lesson_6()
    {
        //Обработка исключение
        // try-catch-finally

        try
        {
            // может произойти исключение 
        }
        catch
        {
            // блок с обработкой исключение
        }

        /*
        •	DivideByZeroException – Деление на ноль.
        •	IndexOutOfRangeException – Выход за границы массива.
        •	NullReferenceException – Попытка обращения к null объекту.
        •	InvalidOperationException – Неверное состояние объекта.
        •	FileNotFoundException – Файл не найден.
        •	FormatException – Неверный формат данных.
         */

        int result;
        int a = 0;
        int b = 0;
        string text = string.Empty; // ""

        try
        {
            a = 10;
            b = 0;
            result = a / b;

            int[] ints = [5, 1, 2];

            var test = ints[5];

            Console.WriteLine(result);
        }
        catch (DivideByZeroException exception)
        {
            Console.WriteLine($"Ошибка: {exception.Message}");
            b = 1;
            result = a / b;
            text.Count();
        }
        catch (Exception exRange)
        {
            Console.WriteLine($"Ошибка: Вышли за границы массива");
        }

        Console.WriteLine();


        // ----------------------------------||------------------------------
        // Выбрасывание исключений throw
        int c = 10;
        int z = 0;

        //if (z == 0)
        //    throw new Exception($"Ошибка: На ноль делить нельзя");

        if (z == 0)
        {
            try
            {
                throw new Exception($"Ошибка!!");
            }
            catch
            {
                Console.WriteLine();
            }
        }

        // ----------------------------------||------------------------------
        try
        {
            throw new DivideByZeroCustomException("Это моя ошибка по поводу деления на ноль");
        }
        catch
        {

        }

        Console.WriteLine();

        // ----------------------------------||--------------------------------
        try
        {

        }
        catch (Exception ex)
        {

        }
        finally
        {
            // ПОПАДЁМ ВСЕГДА СЮДА!!!!
        }

        // ----------------------------------||--------------------------------

        try
        {
            int value = -5;
            if (value < 0)
                throw new Exception("Число не может быть отрицательным");
        }
        catch (Exception ex) when (ex.Message.Contains("отрицательным"))
        {
            Console.WriteLine("Обработано");
        }
    }
}

class DivideByZeroCustomException : Exception
{
    public DivideByZeroCustomException(string message) : base(message)
    {
        Console.WriteLine(message);
    }
}
