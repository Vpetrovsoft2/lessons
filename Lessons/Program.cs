// Serilog
using Serilog;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

Log.Verbose("ОЧЕНЬ ПОДРОБНО!");
Log.Information("Приложение запущено.");
Log.Debug($"Отладочная информация: {DateTime.Now}");
Log.Warning("Это предупреждение");
Log.Error("Это сообщение об ошибке");

try
{
    throw new Exception();
}
catch (Exception ex)
{
    Log.Fatal($"{ex}, произошло фатальное исключение");
}

Log.CloseAndFlush();







// System.IO

// File - Статические методы для работы с файлами
// FileInfo - То же что и File, только через экземпляр
// Directory - Работа с папками (каталоги)
// DirecoryInfo - экземпляр
// StreamReader - Чтение текстовый файлов
// StreamWriter - Запись в текстовые файлы
// FileStream - Универсальный поток для чтения/записи

string path = "example.txt";

// Построчное чтение/запись
using (StreamReader reader = new(path))
{
    string? line;
    while ((line = reader.ReadLine()) != null)
        Console.WriteLine(line);
}

string[] lines = [ "Первая строка", "Вторая строка", "Третья строка"];
using (StreamWriter writer = new(path))
{
    foreach (string line in lines)
        writer.WriteLine(line);
};


Console.WriteLine();

//-------------------------------------||----------------------------------
// чтение/запись из файла

string content = "Привет, мир!";
string contentRead = string.Empty;

if (File.Exists(path))
    contentRead = File.ReadAllText(path);
else
    Console.WriteLine("Файл не найден");


File.WriteAllText(path, content);


