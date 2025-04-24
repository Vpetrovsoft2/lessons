// ООП
/* 
 Икапсуляция
 Наследование
 Полиморфизм
 Абстракция
 */

using Lessons.Lesson8.Cats;

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










