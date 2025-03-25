namespace Lessons.Lesson1
{
    internal class Lesson1
    {
        public void Lesson12()
        {
            Console.WriteLine("Введите переменную"); // вывод чего угодно в консоль
            string da5 = Console.ReadLine();


            Console.WriteLine();

            // ------------------------------------------||-------------------------------------------

            // Переменные
            int a1; // тип данных + имя
            string hello;

            hello = "Hello drug";
            hello = "true";
            a1 = 5;
            a1 = 109;
            a1 = 592;

            int test = 1;


            // ------------------------------------------||-------------------------------------------


            // Значимые и Ссылочные

            // Значимые
            int da = 1; // от -2147483648 до 2147483647
            uint a = 32; // от 0 до 4294967295 
            long da2 = 2; // от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 
            ulong b = 412312412412412; //от 0 до 18 446 744 073 709 551 615 

            short p = 1;
            ushort o = 0;
            float floatDa = 23.5F; // от -3.4*1038 до 3.4*1038
            double doubleDa = 23.1; // от ±5.0*10-324 до ±1.7*10308
            decimal decimalDa = 23.1M; //от ±1.0*10-28 до ±7.9228*1028

            bool isDead = false;

            char symbol = 'f'; // символ

            //ссылочные

            string stroka = "Привет!"; //строки
            object obj = null; //объекты и классы
            int[] array = { }; // Массивы


            // ------------------------------------------||-------------------------------------------

            // Арифмитические Операторы
            // * - умножение
            // - - вычитание
            // + - сложение
            // / - деление
            // % - остаток от деления

            int a2 = 7;
            int b2 = 29;

            int sum = a2 + b2;
            float del = a2 / b2 - (a2 + b2);
            int test2 = a2 * a2;

            // инкремент и декремент
            int c = a2 + 1;
            int d = a2++; //инкремент
            int f = a2--; // a2 - 1 - декремент

            // постфиксный инкремент и декремент
            int g = ++a2;
            int h = --b2;

            // ------------------------------------------||-------------------------------------------
            // Операторы сравнение

            // == - равно
            // != - не равно
            // >= - больше или равно
            // <= - меньше или равно
            // < - меньше
            // > - больше

            string name1 = "Виталий";
            string name2 = "Виталий";

            bool isNameEqual = name1 == name2;


            // Условие if else

            int j = 15;
            int k = 16;

            bool isEqual = j == k;
            bool isMenshe = j < k;
            bool isBolshe = j > k;

            // bool 
            if (isEqual)
            {
                Console.WriteLine("равно");
            }
            else if (isMenshe)
            {
                Console.WriteLine("j меньше k");
            }
            else if (isBolshe)
            {
                Console.WriteLine("j больше k");
            }
            else
            {
                Console.WriteLine("не равно");
            }


            // ------------------------------------------||-------------------------------------------
            // Логические операторы

            // && - логическое И
            // || - логическое ИЛИ
            // ! - логичесое НЕ

            int j1 = 15;
            int k1 = 16;
            int c1 = 18;

            bool isTest = j1 < k1 &&
                          k1 < c1 &&
                          j1 > k1; // если оба условия == true

            Console.WriteLine(isTest);



            //true   //false     //false
            bool isTest2 = j1 < k1 || k1 < c1 || j1 > k1; // если хотябы одно условие true - тогда общий результат true

            Console.WriteLine(isTest2);

            Console.WriteLine(!isTest2);








            // пример задачи
            /* 
             Напишите программу, которая:

            Запрашивает у пользователя логин и пароль.

            Сравнивает введённые данные с заранее заданными значениями (например, логин "admin", пароль "qwerty123").

            Выводит сообщение о результате проверки (успешный вход или ошибка).
            */

            string trueLogin = "admin";
            string truePassword = "qwerty123";

            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();

            bool isLogin = login == trueLogin;
            bool isPassword = password == truePassword;

            if (isLogin && isPassword)
            {
                Console.WriteLine("Вход совершён успешно");
            }
            else
            {
                if (!isLogin)
                {
                    Console.WriteLine("Логин не верный");
                }
                else if (!isPassword)
                {
                    Console.WriteLine("Пароль не верный");
                }
            }
        }
    }
}
