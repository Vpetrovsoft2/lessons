using OpenQA.Selenium;

namespace Autotests.Pages.NavigationPages.WidgetsPage.SliderPage;

public class SliderPage
{
    public static By SliderSelector => By.CssSelector("div[id='sliderContainer'] input[type='range']");
    public static IWebElement Slider => DI.Driver.FindElement(SliderSelector);
    public static IWebElement InputSlider => DI.Driver.FindElement(By.CssSelector("div[id='sliderContainer'] input[id='sliderValue']"));
}
