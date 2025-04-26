using System.Threading.Tasks;

namespace Lessons.Lesson9;

public class Lesson9
{
    // Многопоточные методы
    public static void TestThread()
    {
        Thread thread = new(DoWork());
        thread.Start();
    }

    private Thread DoWork()
    {
        Thread.Sleep(2000);
        Console.WriteLine("Работа в отдельном потоке завершена.");
        return new();
    }

    // Асинхронные методы
    public static async Task<string> Async()
    {
        Console.WriteLine("Загрузка началась....");

        string content = await LoadDataAsync();
        Thread.Sleep(5000);

        Console.WriteLine("Данные загружены: ");
        
        return content;
    }

    public static async Task<string> LoadDataAsync()
    {
        using (var client = new HttpClient())
        {
            return await client.GetStringAsync("https://example.com");
        }
    }
}
