using OpenQA.Selenium;

namespace Autotests.Pages.NavigationPages.WidgetsPage.DatePickerPage;

public class DatePickerPage
{
    public static By InputDatePickerMonthYearSelector => By.CssSelector("input[id='datePickerMonthYearInput']");
    public static IWebElement InputDatePickerMonthYear => DI.Driver.FindElement(InputDatePickerMonthYearSelector);
}
