using Autotests.Factory;

namespace Autotests.UITests.TableTests;

public class TebleTests : BaseTests
{
    [Test]
    public void TableAddEntityTest()
    {
        DI.NavigationHelper.NavigateToWebTablesPage();

        int countBefore = DI.ElementsPageHelper.GetRowsDataFromTable().Count;

        DI.ElementsPageHelper.AddNewRowInTable(new AddUserWebTableFactory());

        int countAfter = DI.ElementsPageHelper.GetRowsDataFromTable().Count;

        Assert.AreEqual(countBefore + 1, countAfter);
    }
}
