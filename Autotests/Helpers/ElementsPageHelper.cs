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
}
