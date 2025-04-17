//namespace Lessons.Secret
//{
//    internal class Secret
//    {
//        public void Secr()
//        {
//            CatsJournal catsJournal = new();

//            SimpleCat catVasya = new("Вася", "Рыжий", 15);
//            catVasya.GetCoatColor();
//            catsJournal.AddCat(catVasya);

//            DeadCat catSerega = new("Серёга", "-", -5);
//            catSerega.GetCoatColor();
//            catSerega.WhenCatIsDead();
//            catsJournal.AddCat(catSerega);

//            SphynxCat catCleopatra = new("Клеопатра", "Чёрный", 3);
//            catCleopatra.GetCoatColor();
//            catsJournal.AddCat(catCleopatra);


//        }


//        public abstract class Cats
//        {
//            private string? _name;
//            private string? _coatColor;
//            private int _age;

//            protected Cats(string name, string coatColor, int age)
//            {
//                _name = name;
//                _coatColor = coatColor;
//                _age = age;
//            }

//            public string Name
//            {
//                get
//                {
//                    return _name!;
//                }
//                set
//                {
//                    _name = value;
//                }
//            }

//            public string CoatColor
//            {
//                get
//                {
//                    return _coatColor!;
//                }
//                set
//                {
//                    _coatColor = value;
//                }
//            }

//            public int Age
//            {
//                get
//                {
//                    return _age;
//                }
//                set
//                {
//                    _age = value;
//                }
//            }

//            public abstract void GetCoatColor();
//            public virtual void WhatCatIsLove() =>
//                Console.WriteLine($"{Name} - любит рыбу");

//        }

//        public interface ICatIsDead
//        {
//            void WhenCatIsDead();
//        }

//        class CatsJournal
//        {
//            private List<Cats> _cats = [];

//            public void AddCat(Cats cat)
//            {
//                _cats.Add(cat);
//                Console.WriteLine($"{cat.Name} добавлен в журнал");
//            }

//            public void ShowAllCats()
//            {
//                foreach (var cat in _cats)
//                    Console.WriteLine($"{cat.Name} - {cat.CoatColor}\n");
//            }
//        }

//        public class SphynxCat : Cats
//        {
//            public SphynxCat(string name, string coatColor, int age) : base(name, coatColor, age)
//            {
//            }

//            public override void GetCoatColor() =>
//                Console.WriteLine($"{Name} - сфинкс, у него нету шерсти");

//            public override void WhatCatIsLove() =>
//                Console.WriteLine($"{Name} любит корм");
//        }

//        public class DeadCat : Cats, ICatIsDead
//        {
//            public DeadCat(string name, string coatColor, int age) : base(name, coatColor, age)
//            {
//            }

//            public override void GetCoatColor()
//            {
//                Console.WriteLine($"{Name} умер, цвет шерсти неизвестен");
//            }

//            public void WhenCatIsDead() =>
//                Console.WriteLine($"{Name} умер {Math.Abs(Age)} года назад");

//            public override void WhatCatIsLove() =>
//                Console.WriteLine($"{Name} умер, вкусовые предпочтения не известны");
//        }

//        public class SimpleCat : Cats
//        {
//            public SimpleCat(string name, string coatColor, int age) : base(name, coatColor, age)
//            {
//            }

//            public override void GetCoatColor() =>
//                Console.WriteLine($"{Name} имеет {CoatColor} цвет шерсти");

//        }
//    }
//}
