using System.Linq;

// LINQ
// вывести все числа которые делятся на 2
List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
List<int> result = [];

// ----||----
foreach (int number in numbers)
{
    if (number % 2 == 0)
        result.Add(number);
}

Console.WriteLine(string.Join(", ", result));


// ----||----
// Where - где условие true
Console.WriteLine(string.Join(", ", numbers.Where(number => number % 2 == 0)));

// ----||----
// Select
//Перемножить все число последовательности на 2
// Что-то выбрать без условия
var result2 = numbers.Select(number => number * 2).ToList();
Console.WriteLine(string.Join(" | ", result2));

// ----||----
// OrederBy, OrderByDescending
// GroupBy

var order = numbers.OrderBy(number => number).ToList();
var orderDesc = numbers.OrderByDescending(number => number).ToList();

Console.WriteLine();

var group = numbers.GroupBy(number => number).ToList();

Console.WriteLine();

// ----||----
// Агрегатные операции
int sum = numbers.Sum();          // Сумма
int count = numbers.Count();      // Количество элементов
int max = numbers.Max();          // Максимум
int min = numbers.Min();          // Минимум
double average = numbers.Average();  // Среднее

// Вывести все числа которые больше среднего

var result3 = numbers.Select(y => y)
                     .Where(x => x > average)
                     .Where(z => z < 7).ToList();

string text = "!Всем привет! Я Василий,,, ";

string result5 = text.Replace("!", "")
                     .Replace(",", "")
                     .Replace(" ", "");

Console.WriteLine();




