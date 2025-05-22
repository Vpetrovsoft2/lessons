using Allure.NUnit.Attributes;
using Autotests.Factory;

namespace Autotests.UITests.TableTests;

public class TebleTests : BaseTests
{
    [Test]
    [TestCase(Author = "Vitaly Petrov", Description = "Добавление сущности в таблицу")]
    [AllureTag("Table")]
    [AllureLink("Test-case #1", "https://allure_testcases.ru")]
    public void TableAddEntityTest()
    {
        DI.NavigationHelper.NavigateToWebTablesPage();

        int countBefore = DI.ElementsPageHelper.GetRowsDataFromTable().Count;

        DI.ElementsPageHelper.AddNewRowInTable(new AddUserWebTableFactory());

        int countAfter = DI.ElementsPageHelper.GetRowsDataFromTable().Count;

        DI.AllureReportHelper.TryRunStep("Сравниваем результаты теста", () => 
        {
            if (countBefore + 1 == countAfter)
                DI.AllureReportHelper.MessageInNewStep($"Значение строк до: {countBefore} увеличелось на 1: {countAfter}");
            else
                DI.AllureReportHelper.ErrorMessageInNewStep($"Значение строк до: {countBefore} не увеличелось на 1: {countAfter}");
        });
    }
}
