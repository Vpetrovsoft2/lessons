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





