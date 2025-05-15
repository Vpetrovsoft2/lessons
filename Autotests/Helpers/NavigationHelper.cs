using Autotests.Pages;
using Autotests.Pages.NavigationPages;
using Autotests.Pages.NavigationPages.ElementsPage;
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
        MainPage.Forms.Click();
        FormsPage.BookStore.Click();

        WaitElementUntilClickable(FormsPage.LoginSelector);

        FormsPage.Login.Click();

        WaitElementUntilClickable(LoginPage.ButtonNewUserSelector);

        LoginPage.ButtonNewUser.Click();
    }

    /// <summary>
    /// Переходим на страницу Web Tables
    /// </summary>
    public void NavigateToWebTablesPage()
    {
        MainPage.Elements.Click();
        ElementsPage.WebTables.Click();

        WaitElementUntilClickable(ElementsPage.TableSelector);
    }
}
