using OpenQA.Selenium;

namespace Autotests.Pages;

public class FormsPage
{
    // Book Store Application
    public static By BookStore => By.XPath("//div[text()='Book Store Application']");
    public static By Login => By.CssSelector("div[class='element-list collapse show'] ul li[id='item-0']");

}
