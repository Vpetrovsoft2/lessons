using OpenQA.Selenium;

namespace Autotests.Pages.NavigationPages.ElementsPage;

public class WebTablesPage
{
    // Элементы страницы
    public static IWebElement ButtonAdd => DI.Driver.FindElement(By.CssSelector("button[id='addNewRecordButton']"));

    // Таблица
    public static By TableSelector => By.CssSelector("div[class='web-tables-wrapper']");
    public static IWebElement Table => DI.Driver.FindElement(TableSelector);
    public static List<IWebElement> Rows => DI.Driver.FindElements(By.CssSelector("div[class='rt-table'] div[class='rt-tbody'] div[class='rt-tr-group']")).ToList();
    public static List<IWebElement> RowByIndex => DI.Driver.FindElements(By.CssSelector("div[class='rt-table'] div[class='rt-tbody'] div[class='rt-tr-group']:nth-child({{0}}) > div > div")).ToList();

}
