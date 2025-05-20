using OpenQA.Selenium;

namespace Autotests.Pages.NavigationPages.ElementsPage.CheckBoxPage;

public static class CheckBoxPage
{
    public static IWebElement ButtonHome => DI.Driver.FindElement(By.XPath("//*[@id='tree-node']/ol/li/span/button"));
    public static IWebElement ButtonDesktop => DI.Driver.FindElement(By.XPath("//*[@id='tree-node']/ol/li/ol/li[1]/span/button"));


    public static IWebElement CheckBoxHome => DI.Driver.FindElement(By.CssSelector("label[for='tree-node-home']"));
    public static By CheckBoxHomeSelector => By.CssSelector("label[for='tree-node-home']");
    public static IWebElement CheckBoxNotes => DI.Driver.FindElement(By.CssSelector("label[for='tree-node-notes']"));
    public static IWebElement CheckBoxCommands => DI.Driver.FindElement(By.CssSelector("label[for='tree-node-commands']"));
    public static IWebElement CheckBoxDesktop => DI.Driver.FindElement(By.CssSelector("label[for='tree-node-desktop']"));

    public static IWebElement TextResult => DI.Driver.FindElement(By.CssSelector("div[id='result']"));
}
