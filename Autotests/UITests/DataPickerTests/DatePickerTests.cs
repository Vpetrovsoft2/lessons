using Autotests.Pages.NavigationPages.WidgetsPage.DatePickerPage;
using OpenQA.Selenium;

namespace Autotests.UITests.DataPickerTests;

public class DatePickerTests : BaseTests
{
    [Test]
    public void DatePickerByInput()
    {
        DI.NavigationHelper.NavigateToDatePockerPage();

        TimeZoneInfo userTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Chicago");
        DateTime userLocalTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, userTimeZone);

        TimeZoneInfo userTimeZone2 = TimeZoneInfo.FindSystemTimeZoneById("Asia/Tokyo");
        DateTime userLocalTime2 = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, userTimeZone2);

        TimeZoneInfo userTimeZone3 = TimeZoneInfo.Local;
        DateTime userLocalTime3 = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, userTimeZone3);

        IWebElement datePicker = DatePickerPage.InputDatePickerMonthYear;

        //int length = datePicker.Text.Length;
        datePicker.Click();

        for (int i = 0; i < 10; i++)
            datePicker.SendKeys(Keys.Backspace);

        datePicker.SendKeys(userLocalTime3.AddMonths(-2).ToString("MM/dd/yyyy"));


    }
}
