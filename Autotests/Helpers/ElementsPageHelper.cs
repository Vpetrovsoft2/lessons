using Autotests.Factory;
using Autotests.Models;
using Autotests.Pages.NavigationPages.ElementsPage;
using OpenQA.Selenium;

namespace Autotests.Helpers;

public class ElementsPageHelper
{
    /// <summary>
    /// Получить данные из таблицы
    /// </summary>
    /// <returns>List<ElementsWebTableModel></returns>
    public List<ElementsWebTableModel> GetRowsDataFromTable()
    {
        List<IWebElement> rows = WebTablesPage.Rows;
        List<ElementsWebTableModel> listRows = new();
        string result = string.Empty;

        DI.AllureReportHelper.RunStep("Получаем строки из таблицы", () => 
        { 
            foreach (var row in rows)
            {
                result = row.Text.Replace(" ", "");
                if (!string.IsNullOrEmpty(result))
                {
                    string[] stringArray = result.Split("\r\n");

                    listRows.Add(new ElementsWebTableModel
                    {
                        FirstName = stringArray[0],
                        LastName = stringArray[1],
                        Age = int.Parse(stringArray[2]),
                        Email = stringArray[3],
                        Salary = int.Parse(stringArray[4]),
                        Department = stringArray[5]
                    });
                }
            }
        });

        return listRows;
    }

    /// <summary>
    /// Создать нового пользователя
    /// </summary>
    /// <param name="factory">Тестовые данные</param>
    public void AddNewRowInTable(AddUserWebTableFactory factory)
    {
        DI.AllureReportHelper.RunStep("Добавляем строку в таблицу", () => 
        { 
            WebTablesPage.ButtonAdd.Click();

            WebTablesModalPage.InputFirsName.SendKeys(factory.FirstName);
            WebTablesModalPage.InputLastName.SendKeys(factory.LastName);
            WebTablesModalPage.InputEmail.SendKeys(factory.Email);
            WebTablesModalPage.InputAge.SendKeys(factory.Age);
            WebTablesModalPage.InputSalary.SendKeys(factory.Salary);
            WebTablesModalPage.InputDepartment.SendKeys(factory.Department);

            WebTablesModalPage.ButtonSubmit.Click();
        });
    }

    /// <summary>
    /// Удаление строки в таблице
    /// </summary>
    /// <param name="index">Индекс строки в таблице</param>
    public void DeleteRowInTable(int index)
    {
        DI.AllureReportHelper.TryRunStep($"Удаление строки в таблице", () =>
        {
            var deleteButton = WebTablesPage.DeleteButtons[index];
            deleteButton.Click();
        });
    }

    /// <summary>
    /// Получение индекса искомой строки из таблицы
    /// </summary>
    /// <param name="description"></param>
    /// <param name="match">Условие поиска</param>
    /// <returns>Индекс строки, лист всех строк</returns>
    public (int IndexRow, List<ElementsWebTableModel> ListElementsWebTableModel) GetRowIndexFromTable(
        string description)
    {
        List<ElementsWebTableModel> listElementsWebTableModel = DI.ElementsPageHelper.GetRowsDataFromTable();

        int countBefore = listElementsWebTableModel.Count;

        int index_element =
            DI.AllureReportHelper.RunStep($"Ищем элемент: {description}", () =>
            {
                int index_element = listElementsWebTableModel.FindIndex(0, countBefore, x => x.FirstName == description);

                if (index_element == -1)
                    DI.AllureReportHelper.ErrorMessageInNewStep($"Не найден элемент: {description}", fatalError: true);

                return index_element;
            });

        return (index_element, listElementsWebTableModel);
    }

    /// <summary>
    /// Проверка количества строк в таблице
    /// </summary>
    /// <param name="expectedRows">Ожидаемое количество строк</param>
    public void CheckCountRows(int expectedRows)
    {
        DI.AllureReportHelper.TryRunStep($"Проверка количества строк в таблице", () =>
        {
            int countAfter = DI.ElementsPageHelper.GetRowsDataFromTable().Count;
            string messageCount = $"Ожидалось: {expectedRows}, стало: {countAfter}";

            if (countAfter != expectedRows)
            {
                DI.AllureReportHelper.ErrorMessageInNewStep(messageCount);
            }
            else
            {
                DI.AllureReportHelper.MessageInNewStep(messageCount);
            }
        });
    }
}
