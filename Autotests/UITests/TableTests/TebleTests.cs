using Allure.NUnit.Attributes;
using Autotests.Factory;
using Autotests.Models;
using Autotests.Pages.NavigationPages.ElementsPage;
using OpenQA.Selenium.Support.UI;

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

    [Test]
    public void TableDeleteEntityTest()
    {
        string expectedFirstName = "Alden";

        DI.NavigationHelper.NavigateToWebTablesPage();

        var (index_element, listElementsWebTableModelBefore) = DI.ElementsPageHelper.GetRowIndexFromTable(expectedFirstName);

        int countBefore = listElementsWebTableModelBefore.Count;

        DI.ElementsPageHelper.DeleteRowInTable(index_element);

        List<ElementsWebTableModel> listElementsWebTableModelAfter = DI.ElementsPageHelper.GetRowsDataFromTable();

        DI.AllureReportHelper.TryRunStep($"Проверка удаления элемента", () =>
        {
            int countAfter = listElementsWebTableModelAfter.Count;

            if (countBefore != countAfter + 1)
                DI.AllureReportHelper.ErrorMessageInNewStep($"Количество элементов до: {countBefore}, стало: {countAfter} ");

            for (int i = 0; i < listElementsWebTableModelAfter.Count; i++)
                if (listElementsWebTableModelAfter[i].FirstName == expectedFirstName)
                    DI.AllureReportHelper.ErrorMessageInNewStep($"Элемент {listElementsWebTableModelAfter[i].FirstName} не удалён", fatalError: true);
        });

    }

    [Test]
    [TestCase(5)]
    [TestCase(10)]
    public void TableCheckPaginationTest(int rows)
    {
        int needCountRows = rows + 1;

        DI.NavigationHelper.NavigateToWebTablesPage();

        SelectElement dropDownRow = new(WebTablesPage.DropDownRows);
        dropDownRow.SelectByValue("100");

        int countWebTable = DI.ElementsPageHelper.GetRowsDataFromTable().Count;

        if (countWebTable < needCountRows)
        {
            int needCountAddRows = needCountRows - countWebTable;

            for (int i = 0; i < needCountAddRows; i++)
            {
                DI.ElementsPageHelper.AddNewRowInTable(new AddUserWebTableFactory());
            }
        }

        DI.ElementsPageHelper.CheckCountRows(needCountRows);

        dropDownRow.SelectByValue(rows.ToString());

        DI.ElementsPageHelper.CheckCountRows(rows);

        DI.AllureReportHelper.TryRunStep($"Проверка пагинации страниц", () =>
        {
            int countPages = int.Parse(WebTablesPage.TextCountPage.Text);

            if (countPages == 2)
            {
                DI.AllureReportHelper.MessageInNewStep($"Количество страниц: {countPages}");
            }
            else
            {
                DI.AllureReportHelper.ErrorMessageInNewStep($"Ожидалось 2, найдено: {countPages}");
            }
        });
    }
}


