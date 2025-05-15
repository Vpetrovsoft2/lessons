using OpenQA.Selenium;

namespace Autotests.Pages.NavigationPages;

public class FormsPage
{
    // Book Store Application
    public static IWebElement BookStore => DI.Driver.FindElement(By.XPath("//div[text()='Book Store Application']"));

    public static By LoginSelector => By.CssSelector("div[class='element-list collapse show'] ul li[id='item-0']");
    public static IWebElement Login => DI.Driver.FindElement(LoginSelector);
}
