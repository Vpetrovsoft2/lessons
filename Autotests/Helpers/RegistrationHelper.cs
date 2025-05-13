using Autotests.Factory;
using Autotests.Pages;
using OpenQA.Selenium;

namespace Autotests.Helpers;

public class RegistrationHelper : BaseHelper
{
    public RegistrationHelper(IWebDriver driver) : base(driver)
    {
    }

    /// <summary>
    /// Заполнение полей регистрации
    /// </summary>
    /// <param name="factory">Тестовые данные</param>
    public void Registration(RegistrationDataFactory factory)
    {
        RegistrationPage.FirstName.SendKeys(factory.FirstName);
        RegistrationPage.LastName.SendKeys(factory.LastName);
        RegistrationPage.UserName.SendKeys(factory.UserName);
        RegistrationPage.Password.SendKeys(factory.Password);
    }

    /// <summary>
    /// Проверка капчи
    /// </summary>
    /// <param name="action">Что </param>
    public void CheckReCapcha(Action action)
    {
        // switch to iframe
        Driver.SwitchTo().Frame(Driver.FindElement(By.CssSelector("iframe[title='reCAPTCHA']")));

        action.Invoke();

        //Возвращаемся из iframe
        Driver.SwitchTo().DefaultContent();
    }
}
