using OpenQA.Selenium;

namespace Autotests.Pages.NavigationPages.ElementsPage;

public class ElementsPage
{
    public static By WebTablesSelector = By.XPath("//span[text()='Web Tables']");
    public static IWebElement WebTables = DI.Driver.FindElement(WebTablesSelector);
    public static IWebElement CheckBox = DI.Driver.FindElement(By.XPath("//span[text()='Check Box']"));
}
