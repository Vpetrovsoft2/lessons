using System.Text;

namespace Lessons.Lesson3;

public class Lesson3
{
    public void Lesson_3()
    {
        // ЦИКЛЫ
        // for | while | do while | foreach

        // while

        while (false)
        {

        }

        bool isDownload = false; // результат API запроса

        int count = 0;
        while (!isDownload && count < 5)
        {
            Thread.Sleep(1); // 1 секунда
            Console.WriteLine("Проверяем");
            isDownload = false; // результат GET запроса
            count++;
        }

        if (count == 5)
            Console.WriteLine("Ошибка, долгая загрузка");


        // do while
        int j = 0;
        do
        {
            j++;
            Console.WriteLine($"Итерация: {j}");
        }
        while (j < 5);


        int h = 10;
        int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9];

        // for
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 3 || array[i] == 7)
                continue;

            Console.WriteLine(array[i]);
        }

        List<string> listNames = ["Жулик", "Шавка", "Барбос"];

        for (int i = 0; i < listNames.Count; i++)
            Console.WriteLine(listNames[i]);

        // foreach

        List<string> listNewNames = [];
        foreach (var name in listNames)
        {
            if (name == "Барбос")
            {
                Console.WriteLine("Барбос найден");
                break;
            }

            listNewNames.Add(name);
            Console.WriteLine(name);
        }


        // --------------------------------------||------------------------------------------
        // string
        // Конкатенация == объединение

        string s1 = "Привет,";
        string s2 = "друг";
        int a = 123;

        var result = s1 + " " + s2 + "!!!!!!!" + a;

        var result1 = string.Concat(s1, " ", s2, "!!!!!!");

        Console.WriteLine(result);

        // Интерполяция

        string name10 = "Alexandra";
        int age = 21;

        Console.WriteLine($"My name is {name10} and I'm {age} years old.");

        Console.WriteLine(string.Format("My name is {0} and I'm {1} years old.", name10, age));

        // StringBuilder
        StringBuilder sb = new();

        sb.Append(s1);
        sb.Append(" ");
        sb.Append(s2);
        sb.Append("!!!!!!");

        string result3 = sb.ToString();
        Console.WriteLine(result3);

        // Изменение строк

        string text = "Это урок номер 3";

        string sub1 = text.Substring(9);
        string sub2 = text.Substring(0, 9);

        Console.WriteLine();

        // Замена

        string text1 = "25,148484_number";
        string replaced = text1.Replace(",", ".").Replace("_number", "").Trim();


        text1.ToUpper();
        text1.ToLower();

        string text2 = " q ";
        string da = text2.Trim();

        string text3 = string.Join(",", listNames);
        string[] da3 = text3.Split(",");

        DateTime now = DateTime.Now;

        string date = now.ToString("yyyy-MM-dd HH:mm:ss");


        Console.WriteLine();


    }
}
