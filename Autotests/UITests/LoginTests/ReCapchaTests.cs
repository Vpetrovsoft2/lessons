using OpenQA.Selenium;
using Autotests.Helpers;
using Autotests.Factory;

namespace Autotests.UITests.LoginTests;

public class ReCapchaTests : BaseTests
{
    [Test]
    public void CheckReCapchaTest()
    {
        DI.NavigationHelper.NavigateToRegistrationPage();

        DI.RegistrationHelper.Registration(new RegistrationDataFactory(password: "wt342tfgwef23"));

        DI.RegistrationHelper.CheckReCapcha(() =>
            DI.Driver.FindElement(By.CssSelector("span[id='recaptcha-anchor']")));
    }

    [Test]
    public void CheckReCapchaOtherElementTest()
    {
        DI.NavigationHelper.NavigateToRegistrationPage();

        DI.RegistrationHelper.Registration(new RegistrationDataFactory());

        DI.RegistrationHelper.CheckReCapcha(() =>
            DI.Driver.FindElement(By.CssSelector("div[role='presentation']")));
    }
}
