using OpenQA.Selenium;

namespace Autotests.Pages.NavigationPages.WidgetsPage;

public class WidgetsPage
{
    public static IWebElement Slider => DI.Driver.FindElement(By.XPath("//span[text()='Slider']"));
    public static IWebElement DatePicker => DI.Driver.FindElement(By.XPath("//span[text()='Date Picker']"));
}
