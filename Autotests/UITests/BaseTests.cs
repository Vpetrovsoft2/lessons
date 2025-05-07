using Autotests.Factory;
using Autotests.Helpers;
using OpenQA.Selenium;

namespace Autotests.UITests;

public class BaseTests
{
    public IWebDriver Driver;
    protected BaseHelper BaseHelper;
    protected NavigationHelper NavigationHelper;

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

        NavigationHelper = new(Driver);
        BaseHelper = new(Driver);
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Driver.Dispose();
    }
}
