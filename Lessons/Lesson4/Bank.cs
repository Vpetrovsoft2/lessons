namespace Lessons.Lesson4;

public class Bank
{

    //Создайте класс BankAccount со следующими свойствами:
    //AccountNumber(string) - номер счета
    //OwnerName(string) - имя владельца
    //Balance(decimal) - текущий баланс
    //Добавьте в класс BankAccount следующие методы:
    //Deposit(decimal amount) - пополнение счета
    //Withdraw(decimal amount) - снятие денег(должна быть проверка, что средств достаточно)
    //DisplayInfo() - вывод информации о счете
    //Создайте класс Program с методом Main, в котором:
    //Создайте экземпляр банковского счета
    //Выполните несколько операций пополнения и снятия
    //Выведите информацию о счете после каждой операции

    private decimal _balance;
    private string _ownerName;
    private string _accountNumber;

    public Bank(decimal balance, string ownerName, string accountNumber)
    {
        _balance = balance;
        _ownerName = ownerName;
        _accountNumber = accountNumber;
    }

    public string? AccountNumber
    {
        get
        {
            return _accountNumber;
        }
    }

    public string? OwnerName
    {
        get
        {
            return _ownerName;
        }
    }

    public  decimal Balance
    {
        get
        {
            return _balance;
        }
    }

    public void Deposit(decimal amount)
    {
        _balance += amount;
        Console.WriteLine($"Баланс пополнен на сумму: {amount}");
    }

    public void Withdraw(decimal amount)
    {
        if (Balance < amount)
            Console.WriteLine("Баланса не достаточно, уменьшите сумму");
        else
        {
            _balance -= amount;
            Console.WriteLine($"Снятие денег на сумму: {amount}");
        }
    }

    public decimal DisplayInfo()
    {
        Console.WriteLine($"{_ownerName}! У Вас на балансе {_accountNumber}: ");
        return Balance;
    }
}
