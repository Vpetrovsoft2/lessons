using OpenQA.Selenium;

namespace Autotests.Pages;

public class LoginPage
{
    public static By ButtonNewUserSelector => By.CssSelector("button[id='newUser']");
    public static IWebElement ButtonNewUser => DI.Driver.FindElement(By.CssSelector("button[id='newUser']"));
}
