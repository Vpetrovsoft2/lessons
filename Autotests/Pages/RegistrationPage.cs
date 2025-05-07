using OpenQA.Selenium;

namespace Autotests.Pages;

public static class RegistrationPage
{
    public static By FirstName => By.CssSelector("input[id='firstname']");
    public static By LastName => By.CssSelector("input[id='lastname']");
    public static By UserName => By.CssSelector("input[id='userName']");
    public static By Password => By.CssSelector("input[id='password']");

}
