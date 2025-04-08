using Lessons.Lesson4;

Bank bank = new(500, "Виталий", "4124124");

bank.Deposit(50);
Console.WriteLine(bank.DisplayInfo());

GetWithdraw(600);

GetWithdraw(111);



void GetWithdraw(decimal amount)
{
    bank.Withdraw(amount);
    Console.WriteLine(bank.DisplayInfo());
}
