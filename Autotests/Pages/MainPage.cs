using OpenQA.Selenium;

namespace Autotests.Pages;

public class MainPage
{
    public static IWebElement Forms => DI.Driver.FindElement(By.XPath("//h5[text()='Forms']"));
    public static IWebElement Elements => DI.Driver.FindElement(By.XPath("//h5[text()='Elements']"));
    public static IWebElement Widgets => DI.Driver.FindElement(By.XPath("//h5[text()='Widgets']"));
}
