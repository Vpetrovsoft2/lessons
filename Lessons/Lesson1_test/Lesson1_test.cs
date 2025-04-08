namespace Lessons.Lesson1_test;

public class Lesson1_test
{
    public void Lesson1_1()
    {
        int a = 10;
        double b = 3.14;
        bool c = true;
        char d = 'A';
        string e = "Hello";

        Console.WriteLine($"Целое число: {a}");
        Console.WriteLine($"Дробное число: {b}");
        Console.WriteLine($"Логическое значение: {c}");
        Console.WriteLine($"Символ: {d}");
        Console.WriteLine($"Строка: {e}");
    }

    public void Lesson1_2()
    {
        Console.WriteLine("Введите первое число:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Сумма: {n1 + n2}");
        Console.WriteLine($"Разность: {(float)n1 - n2}");
        Console.WriteLine($"Произведение: {n1 * n2}");
        Console.WriteLine($"Частное: {(double)n1 / n2}");
    }
}



/*
 //Задача 1//

int a = 10;
double b = 3.14;
bool c = true;
char d = 'A';
string e = "Hello";

Console.WriteLine($"Целое число: {a}");
Console.WriteLine($"Дробное число: {b}");
Console.WriteLine($"Логическое значение: {c}");
Console.WriteLine($"Символ: {d}");
Console.WriteLine($"Строка: {e}");


//Задача 2

Console.WriteLine("Введите первое число:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма: {n1 + n2}");
Console.WriteLine($"Разность: {(float)n1 - n2}");
Console.WriteLine($"Произведение: {n1 * n2}");
Console.WriteLine($"Частное: {(double)n1 / n2}");


//Задача 3

Console.WriteLine("Введите первое число:");
int l1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int l2 = Convert.ToInt32(Console.ReadLine());

bool isEqual = l1 == l2;
if (isEqual)
{
    Console.WriteLine($"{l1} Равно {l2}");
}
else if (l1 > l2)
{
    Console.WriteLine($"{l1} Больше {l2}");
}
else if (l1 < l2)
{
    Console.WriteLine($"{l1} Меньше {l2}");
}



//Задача 4

Console.WriteLine("Введите ваш возраст:");
int age = Convert.ToInt32(Console.ReadLine());

bool ageSuccess = age >= 18;
bool ageFalse = age < 18;
if (ageSuccess)
{
    Console.WriteLine("Вы совершеннолетний");
}
else if (ageFalse)
{
    Console.WriteLine("Вы несовершеннолетний");
}

if (age > 0 && age < 120)
{
    Console.WriteLine("Возраст в допустимом диапазоне");
}
else
{
    Console.WriteLine("Диапазон не допустим");
}



//Задача 5

int count = 5;
int increment = ++count;
int decrement = --count;

Console.WriteLine($"Исходное значение: {count}");
Console.WriteLine($"После инкремента: {increment}");
Console.WriteLine($"После декремента: {decrement}"); 
 
 */