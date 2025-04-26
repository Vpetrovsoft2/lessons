// ООП
/* 
 Икапсуляция
 Наследование
 Полиморфизм
 Абстракция
 */
using Lessons.Lesson8.Cats;
using Lessons.Lesson9;

//---------------------------------||-------------------------------------
// Многопоточный пример


//---------------------------------||-------------------------------------
// Асинхронный пример
var test1 = Lesson9.Async();
var test2 = Lesson9.Async();
var test3 = Lesson9.Async();
var test4 = Lesson9.Async();
var test5 = Lesson9.Async();

Task.WaitAll(test1, test2, test3, test4, test5);

string text = test1.Result + test2.Result + test3.Result + test4.Result + test5.Result;




Console.WriteLine();

CatsJournal catsJournal = new();

SimpleCat catVasya = new("Вася", "Рыжий", 15);
catVasya.GetCoatColor();
catsJournal.AddCat(catVasya);

DeadCat catValera = new("Валера", "-", -1);
catValera.GetCoatColor();
catValera.WhenCatIdDead();
catsJournal.AddCat(catValera);

SphynxCat catCleopatra = new("Клеопатра", "Чёрный", 3);
catCleopatra.GetCoatColor();
catsJournal.AddCat(catCleopatra);

catsJournal.ShowAllCats();









