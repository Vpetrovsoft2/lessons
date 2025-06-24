using Autotests.Pages.NavigationPages.ElementsPage.CheckBoxPage;
using Autotests.Tests.UITests;
using OpenQA.Selenium;

namespace Autotests.Tests.UITests.CheckBoxTests;

public class CheckBoxTests : BaseAPITests
{
    [Test]
    public void CheckBoxDesktopTest()
    {
        DI.NavigationHelper.NavigateToCheckBoxPage();

        CheckBoxPage.ButtonHome.Click();
        CheckBoxPage.ButtonDesktop.Click();

        CheckCheckBox(CheckBoxPage.CheckBoxNotes, "notes");
        CheckCheckBox(CheckBoxPage.CheckBoxCommands, "commands");
        CheckCheckBox(CheckBoxPage.CheckBoxDesktop, "desktop\r\nnotes\r\ncommands");
    }

    private void CheckCheckBox(IWebElement element, string expectedText)
    {
        DI.AllureReportHelper.RunStep($"Проверяем нажатие чек-боса: {element.Text}", () => 
        {
            element.Click();
            string notesText = CheckBoxPage.TextResult.Text.Replace("You have selected :", "").Trim();

            if (notesText == expectedText)
                DI.AllureReportHelper.MessageInNewStep($"Найденный текст: {notesText} соответствует ожидаемому: {expectedText}");
            else
                DI.AllureReportHelper.ErrorMessageInNewStep($"Найденный текст: {notesText} не соответствует ожидаемому: {expectedText}");

            element.Click();
        });
    }
}
