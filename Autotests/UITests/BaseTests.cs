using Autotests.Factory;
using OpenQA.Selenium;

namespace Autotests.UITests;

public class BaseTests
{
    protected IWebDriver Driver;

    [SetUp]
    public void Setup()
    {
    }

    [TearDown]
    public void TearDown()
    {
    }

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        Driver = DriverFactory.CreateDriver();
        Driver.Navigate().GoToUrl("https://demoqa.com/");
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Driver.Dispose();
    }
}
