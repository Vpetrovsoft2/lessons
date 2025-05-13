using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Autotests.Helpers;

public class BaseHelper
{
    protected readonly IWebDriver Driver;

    public BaseHelper(IWebDriver driver)
    {
        Driver = driver;
    }

    /// <summary>
    /// Ожидание пока элемент станет кликабельным
    /// </summary>
    /// <param name="selector">Селектор элемента</param>
    /// <returns>IWebElement</returns>
    public IWebElement WaitElementUntilClickable(By selector)
    {
        //Ожидание
        WebDriverWait wait = new(Driver, TimeSpan.FromSeconds(5));
        return wait.Until(ExpectedConditions.ElementToBeClickable(selector));
    }
}
