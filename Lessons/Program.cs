class Program
{
    static void Main(string[] args)
    {
        int count;

        int a = 1;
        string z = "stroka";
        bool isStroka = false;


        // Анонимный тип данных
        var b = 1;
        var c = "stroka";
        var isStroka1 = false;

        b = 14;

        // ---------------------------------||---------------------------------

        // switch case

        string day = "";

        switch (day)
        {
            case "Monday":
                Console.WriteLine("Сегодня мы едим пельмени!");
                break;
            case "Tuesday":
                Console.WriteLine("Сегодня мы едим свинину!");
                break;
            default:
                Console.WriteLine("Сегодня мы едми рыбу!");
                break;
        }

        if (day == "Monday")
        {
            Console.WriteLine("Сегодня мы едим пельмени!");
        }
        else if (day == "Tuesday")
        {
            Console.WriteLine("Сегодня мы едим свинину!");
        }
        else
        {
            Console.WriteLine("Сегодня мы едми рыбу!");
        }


        // ---------------------------||--------------------------------

        // break and continue
        // break - выйти из конструкции или из циклы
        // continue - продолжить анализ в конструкции

        // ----------------------------||--------------------------------
        // Массивы и Коллекции

        int p = 100;
        int t = 123;
        int h = 1231541;

        string[] array = [];

        var numbers = new int[3] { p, t, h };

        int[] numbers1 = [100, 123, 1231541];

                           // 0         1       2    3   4  5  6     7   8
        long[] arrayLong = [1241241, 124324, 54356, 767, 8, 9, 7654, 4, 234];

        long v = arrayLong[2]; // Взяли из массива значение под индексом 2

        arrayLong[8] = 1; // изменения значения под индексом 8

        long max = arrayLong.Max(); 
        long min = arrayLong.Min();
        long sum = arrayLong.Sum();

        int count1 = arrayLong.Length; // Количество элементов в массиве



        // -----------------------------------||---------------------------------------
        // List<T>

        List<long> list = new();
        List<long> list2 = [];

                                // 0         1       2    3   4  5  6     7   8
        List<long> listLongs = [1241241, 124324, 54356, 767, 8, 9, 7654, 4, 234];

        int count3 = listLongs.Count; // Количество элементов в массиве


        List<string> listString = ["Da", "Net"];

        listString.Add("Privet");

        listString.Remove("Da");
        listString.RemoveAt(0);


        string text = "Тут какой то стих Есенина написан";

        string[] text7 = text.Split(" ");

        List<string> text5 = text.Split(" ").ToList();

        //--------------------------------||------------------------------------------

        // Dictionary<TKey, TValue>

        Dictionary<int, string> dict = new Dictionary<int, string>();

        var people = new Dictionary<int, string>()
        {
            { 5, "Tom"},
            { 3, "Sam"},
            { 11, "Bob"}
        };

        people.Add(15, "Vitaly");

        string name = people[5];

        bool isRemove = people.Remove(11);

        

    }
}