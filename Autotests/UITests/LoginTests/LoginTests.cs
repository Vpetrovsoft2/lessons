using OpenQA.Selenium;
using Autotests.Pages;
using Autotests.Helpers;

namespace Autotests.UITests.LoginTests;

public class LoginTests : BaseTests
{
    [Test]
    public void CheckReCapchaTest()
    {
        NavigationHelper.NavigateToRegistrationPage();

        var firstName = Driver.FindElement(RegistrationPage.FirstName);
        var lastName = Driver.FindElement(RegistrationPage.LastName);
        var userName = Driver.FindElement(RegistrationPage.UserName);
        var password = Driver.FindElement(RegistrationPage.Password);

        firstName.SendKeys("Такой-то");
        lastName.SendKeys("Такой-то");
        userName.SendKeys("Король");
        password.SendKeys("Test123");

        // switch to iframe
        Driver.SwitchTo().Frame(Driver.FindElement(By.CssSelector("iframe[title='reCAPTCHA']")));
        Driver.FindElement(By.CssSelector("span[id='recaptcha-anchor']"));

        //Возвращаемся из iframe
        Driver.SwitchTo().DefaultContent();
    }
}
