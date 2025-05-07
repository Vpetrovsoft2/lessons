using Autotests.Pages;
using OpenQA.Selenium;

namespace Autotests.Helpers;

public class NavigationHelper : BaseHelper
{
    public NavigationHelper(IWebDriver driver) : base(driver)
    {
    }

    /// <summary>
    /// Переходим на страницу с регистрацией
    /// </summary>
    public void NavigateToRegistrationPage()
    {
        // Навигация
        var forms = Driver.FindElement(MainPage.Forms);
        forms.Click();

        var bookStore = Driver.FindElement(FormsPage.BookStore);
        bookStore.Click();

        var login = WaitElementUntilClickable(FormsPage.Login);

        login.Click();

        IWebElement buttonNewUser;
        try
        {
            buttonNewUser = Driver.FindElement(LoginPage.ButtonNewUser);
        }
        catch (NoSuchElementException ex)
        {
            throw ex;
        }

        buttonNewUser.Click();
    }
}
