using OpenQA.Selenium;
using Autotests.Tests.UITests;

namespace Autotests.Pages;

public class RegistrationPage
{
    public static IWebElement FirstName => DI.Driver.FindElement(By.CssSelector("input[id='firstname']"));
    public static IWebElement LastName => DI.Driver.FindElement(By.CssSelector("input[id='lastname']"));
    public static IWebElement UserName => DI.Driver.FindElement(By.CssSelector("input[id='userName']"));
    public static IWebElement Password => DI.Driver.FindElement(By.CssSelector("input[id='password']"));
}
