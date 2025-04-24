//using System.Collections;

//namespace Lessons.Lesson7;

//public class Lesson7
//{
//    public void Lesson_7_Generic()
//    {
//        //List<string> list = new List<string>();

//        TestClass testClaa = new();

//        int a = testClaa.Method<int>(15);

//        bool isEqual = testClaa.AreEqual<double>(25.1, 12.1);

//        bool isEqual2 = testClaa.AreEqual<IntList>(new IntList(), new IntList());

//        // --------------------------||------------------------------
//        // ПРИМЕР
//        var list = new MyList<int>();
//        list.Add(5);
//        list.Add(6);
//        list.Add(7);
//        Console.WriteLine(list.Get(1));

//        var listString = new MyList<string>();
//        listString.Add("Ку");
//    }

//    public void Lesson_7_Delegate()
//    {
//        // Func и Action - делегаты
//        // 1. Action => void

//        Action action = () => Console.WriteLine("Привет, я в делегат");
//        action.Invoke();

//        Action action1 = () =>
//        {
//            Console.WriteLine("Что то выводим");
//            int a = 14;
//            int b = 15124;

//            Console.WriteLine(a + b);
//        };

//        TestClassActFunc testClass = new();
//        testClass.TestMethod(action1);

//        List<Action> actionList = [ action1, action ];

//        // Action с параметрами
//        Action<string, int> actionParam = (name, age) =>
//        {
//            Console.WriteLine($"Name: {name}, Age: {age}");
//        };

//        actionParam.Invoke("Коля", 25);

//        Console.WriteLine();

//        // --------------------------------------------||------------------------------------------------
//        //2. Func => что то возвращает
//        Random random = new();
//        Func<int> getRandomNumber = () =>
//        {
//            Console.WriteLine("Вот случайное число:");
//            return random.Next(0, 199);
//        };

//        int c = testClass.TestFunc(getRandomNumber);
//        Console.WriteLine(c);

//        // Func с параметрами

//        Func<int, int, int, double> funcParams = (a, b, c) =>
//        {
//            Console.WriteLine("Сейчас я что то буду делать");
//            Console.WriteLine($"Вот вывод: {a}, {b}, {c}");
//            return a * b * c;
//        };

//        double pressF = testClass.TestFunc2<double>(funcParams);
//    }
//}

//// Generic
//class MyList<T>
//{
//    private T[] _items = new T[10];
//    private int _count = 0;

//    public void Add(T item)
//    {
//        if (_count == _items.Length)
//            Console.WriteLine("Больше не лезет");
//        else
//            _items[_count++] = item;
//    }

//    public T Get(int index) => _items[index];
//}

//class TestClass
//{
//    // модификатор доступа - Тип данных - Название(параметры)

//    public T Method<T>(T number)
//    {
//        return number;
//    }

//    public bool AreEqualInt(int a, int b) => a.Equals(b);

//    public bool AreEqualString(string a, string b) => a.Equals(b);

//    public bool AreEqualIntList(IntList a, IntList b) => a.Equals(b);

//    // дженериковый

//    public bool AreEqual<T>(T a, T b)
//    {
//        return a.Equals(b);
//    }

//    // where T : class  - только ссылочные типы
//    // where T : struct - только значимые типы
//}


//class IntList
//{
//    private int[] _items = new int[10];
//    public void Add(int item) { }
//}

//class StringList
//{
//    private string[] _items = new string[10];
//    public void Add(string item) { }
//}

//// Дженерики / Generics

//class List<T> // T - какой то тип данных
//{
//    private List<T> _items = new List<T>();
//    public void Add(T item) { }
//}





////Func / Action
//public class TestClassActFunc
//{
//    public void TestMethod(Action action)
//    {
//        action.Invoke();
//    }

//    public int TestFunc(Func<int> func)
//    {
//        int result = func.Invoke();
//        return result;
//    }

//    public T TestFunc2<T>(Func<int, int, int, T> func)
//    {
//        return func.Invoke(5, 4, 3);
//    }

//}