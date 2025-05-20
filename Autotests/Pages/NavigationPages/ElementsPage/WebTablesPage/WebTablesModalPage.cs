using OpenQA.Selenium;

namespace Autotests.Pages.NavigationPages.ElementsPage;

public class WebTablesModalPage
{
    public static IWebElement InputFirsName => DI.Driver.FindElement(By.CssSelector("input[id='firstName']"));
    public static IWebElement InputLastName => DI.Driver.FindElement(By.CssSelector("input[id='lastName']"));
    public static IWebElement InputEmail => DI.Driver.FindElement(By.CssSelector("input[id='userEmail']"));
    public static IWebElement InputAge => DI.Driver.FindElement(By.CssSelector("input[id='age']"));
    public static IWebElement InputSalary => DI.Driver.FindElement(By.CssSelector("input[id='salary']"));
    public static IWebElement InputDepartment => DI.Driver.FindElement(By.CssSelector("input[id='department']"));
    public static IWebElement ButtonSubmit => DI.Driver.FindElement(By.CssSelector("button[id='submit']"));
}
