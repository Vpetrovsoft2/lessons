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

        Assert.AreEqual(countBefore + 1, countAfter);
    }
}
