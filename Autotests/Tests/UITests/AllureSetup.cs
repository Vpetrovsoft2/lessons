using System.Diagnostics;

namespace Autotests.Tests.UITests;

[SetUpFixture]
public class AllureSetup
{
    [OneTimeSetUp]
    public void RunBeforeAnyTests()
    {
        //очищаем предыдущие результаты
        var resultDir = Path.Combine(TestContext.CurrentContext.TestDirectory, "allure-results");
        if (Directory.Exists(resultDir))
            Directory.Delete(resultDir, true);
    }

    [OneTimeTearDown]
    public void GenerateAndOperAllureReport()
    {
        try
        {
            var currentDir = TestContext.CurrentContext.TestDirectory;
            var resultDir = Path.Combine(currentDir, "allure-results");
            var reportDir = Path.Combine(currentDir, "allure-report");

            // Генерируем и запускаем в браузере отчёт
            ProcessStartInfo processSettings = new()
            {
                FileName = "cmd.exe",
                Arguments = "/K allure serve",
                UseShellExecute = true,
                CreateNoWindow = false
            };

            Process.Start(processSettings);
        }
        catch (Exception ex) 
        {
            TestContext.WriteLine($"Failed to generate Allure report: {ex.Message}");
        }
    }
}
