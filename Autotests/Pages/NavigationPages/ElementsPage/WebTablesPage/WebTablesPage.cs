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
    public static List<IWebElement> DeleteButtons => DI.Driver.FindElements(By.CssSelector("div[class='rt-table'] div[class='rt-tbody'] div[class='rt-tr-group'] span[id*='delete-record']")).ToList();
    public static IWebElement DropDownRows => DI.Driver.FindElement(By.CssSelector("span[class='select-wrap -pageSizeOptions'] select"));
    public static IWebElement TextCountPage => DI.Driver.FindElement(By.CssSelector("span[class='-totalPages']"));
}
