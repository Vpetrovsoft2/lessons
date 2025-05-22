using Autotests.Pages;
using Autotests.Pages.NavigationPages;
using Autotests.Pages.NavigationPages.ElementsPage;
using Autotests.Pages.NavigationPages.ElementsPage.CheckBoxPage;
using Autotests.Pages.NavigationPages.WidgetsPage;
using Autotests.Pages.NavigationPages.WidgetsPage.DatePickerPage;
using Autotests.Pages.NavigationPages.WidgetsPage.SliderPage;
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
        DI.AllureReportHelper.RunStep("Выполняем навигацию до страницы WebTables", () => 
        {
            GoToElements();
            ElementsPage.WebTables.Click();

            WaitElementUntilClickable(WebTablesPage.TableSelector);
        });
    }

    /// <summary>
    /// Переходим на страницу Check Box
    /// </summary>
    public void NavigateToCheckBoxPage()
    {
        DI.AllureReportHelper.RunStep("Выполняем навигацию до страницы WebTables", () => 
        { 
            GoToElements();
            ElementsPage.CheckBox.Click();

            WaitElementUntilClickable(CheckBoxPage.CheckBoxHomeSelector);
        });
    }

    /// <summary>
    /// Переходим на страницу Slider
    /// </summary>
    public void NavigateToSliderPage()
    {
        DI.AllureReportHelper.RunStep("Выполняем навигацию до страницы Slider", () => 
        {
            GoToWidgets();
            WidgetsPage.Slider.Click();

            WaitElementUntilClickable(SliderPage.SliderSelector);
        });
    }

    /// <summary>
    /// Переходим на страницу DatePicker
    /// </summary>
    public void NavigateToDatePockerPage()
    {
        GoToWidgets();
        WidgetsPage.DatePicker.Click();

        WaitElementUntilClickable(DatePickerPage.InputDatePickerMonthYearSelector);
    }

    #region LOCAL METHODS
    private void GoToElements() =>
        DI.AllureReportHelper.RunStep("Переходим в выпадающий список Elements", () => 
            MainPage.Elements.Click());

    private void GoToWidgets() =>
        DI.AllureReportHelper.RunStep("Переходим в выпадающий список Widgets", () =>
            MainPage.Widgets.Click());
    #endregion
}
