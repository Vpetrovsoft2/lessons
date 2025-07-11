﻿using AllureService;
using Autotests.Factory;
using Autotests.Helpers;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RestAPIService;

namespace Autotests;

public static class DI
{
    private static readonly Lazy<IServiceProvider> _serviceProvider = new Lazy<IServiceProvider>(Configure);

    public static IServiceProvider ServiceProvider => _serviceProvider.Value;
    public static IWebDriver Driver => ServiceProvider.GetRequiredService<IWebDriver>();
    public static BaseHelper BaseHelper => ServiceProvider.GetRequiredService<BaseHelper>();
    public static NavigationHelper NavigationHelper => ServiceProvider.GetRequiredService<NavigationHelper>();
    public static RegistrationHelper RegistrationHelper => ServiceProvider.GetRequiredService<RegistrationHelper>();
    public static ElementsPageHelper ElementsPageHelper => ServiceProvider.GetRequiredService<ElementsPageHelper>();
    public static AllureReportHelper AllureReportHelper => ServiceProvider.GetRequiredService<AllureReportHelper>();
    public static FormatHelper FormatHelper => ServiceProvider.GetRequiredService<FormatHelper>();
    public static APIHelper APIHelper => ServiceProvider.GetRequiredService<APIHelper>();


    public static RestAPIHelper RestAPIHelper => ServiceProvider.GetRequiredService<RestAPIHelper>();

    public static ServiceProvider Configure()
    {
        var services = new ServiceCollection();

        //IWebDriver
        services.AddSingleton<IWebDriver>(provider => 
        {
            var options = new ChromeOptions();
            options.PageLoadStrategy = PageLoadStrategy.Eager;
            return new ChromeDriver(options);
        });

        //Helpers
        services.AddScoped<BaseHelper>();
        services.AddScoped<NavigationHelper>();
        services.AddScoped<RegistrationHelper>();
        services.AddScoped<ElementsPageHelper>();
        services.AddScoped<FormatHelper>();
        services.AddScoped<APIHelper>();

        //Factory
        services.AddScoped<RegistrationDataFactory>();
        services.AddScoped<AddUserWebTableFactory>();

        //Allure
        services.AddScoped<AllureReportHelper>();

        //RestAPI
        services.AddScoped<RestAPIHelper>();
        
        return services.BuildServiceProvider();
    }
}
