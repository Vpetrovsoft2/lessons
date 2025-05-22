using Allure.NUnit;

namespace Autotests.UITests;

[AllureNUnit]
public class BaseTests
{
    public BaseTests()
    {
    }

    [SetUp]
    public void Setup()
    {
    }

    [TearDown]
    public void TearDown()
    {
        DI.Driver.Navigate().GoToUrl("https://demoqa.com/");
    }

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        DI.Driver.Navigate().GoToUrl("https://demoqa.com/");
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        DI.Driver.Close();
    }
}
