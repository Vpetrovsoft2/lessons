﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Autotests.Factory;

public class DriverFactory
{
    public static IWebDriver CreateDriver(string browser = "chrome")
    {
        IWebDriver driver;

        switch (browser.ToLower())
        {
            case "chrome":
                var options = new ChromeOptions();
                options.PageLoadStrategy = PageLoadStrategy.Eager;
                driver = new ChromeDriver(options);
                break;
            case "firefox":
                driver = new FirefoxDriver();
                break;
            default:
                throw new ArgumentException($"Браузер: {browser} не поддерживается");
        }
        
        return driver;
    }
}
