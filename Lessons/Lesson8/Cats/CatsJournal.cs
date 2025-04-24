namespace Lessons.Lesson8.Cats;

public class CatsJournal
{
    private List<Cats> _cats = [];

    public void AddCat(Cats cat)
    {
        _cats.Add(cat);
        Console.WriteLine($"{cat.Name} добавлен в журнал");
    }

    public void ShowAllCats()
    {
        foreach (var cat in _cats)
            Console.WriteLine($"{cat.Name} - {cat.CoatColor}");
    }
}
