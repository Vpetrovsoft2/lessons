using Autotests.Pages.NavigationPages.WidgetsPage.SliderPage;
using Autotests.Tests.UITests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Autotests.Tests.UITests.SliderTests;

public class SliderTests : BaseAPITests
{
    private const int weigth = 469;

    [Test]
    public void SliderTest()
    {
        DI.NavigationHelper.NavigateToSliderPage();

        int sliderNumber =
            DI.AllureReportHelper.RunStep("Анализируем положение слайдера", () =>
            {
                return int.Parse(SliderPage.InputSlider.GetAttribute("value")!);
            });

        int rndNumber = DI.FormatHelper.GetRandomNumberInt(5, 100);
        DI.AllureReportHelper.MessageInNewStep($"Двигаем на значение: {rndNumber}");

        DI.AllureReportHelper.RunStep("Двигаем слайдер", () => 
        { 
            Actions actions = new(DI.Driver);
            int pxl = weigth / 100 * rndNumber;

            DI.AllureReportHelper.RunStep("Двигаем слайдер в позицию 0", () => 
                actions.ClickAndHold(SliderPage.Slider)
                        .MoveToLocation(0, 0)
                        .Release()
                        .Perform());

            DI.AllureReportHelper.RunStep($"Двигаем слайдер в позицию {rndNumber}", () => 
                actions.ClickAndHold(SliderPage.Slider)
                        .MoveByOffset(pxl, 0)
                        .Release()
                        .Perform());
        });

        DI.AllureReportHelper.RunStep("Проверяем что слайдер был корректно установлен", () => 
        { 
            int numberAfter = int.Parse(SliderPage.InputSlider.GetAttribute("value")!);

            if (numberAfter == 0)
                DI.AllureReportHelper.ErrorMessageInNewStep($"Слайдер не был двинут");
            else
                DI.AllureReportHelper.MessageInNewStep($"Слайдер был двинут");
        });
    }

    [Test]
    [TestCase(Description = "Нерабочий javaScript")]
    public void SliderJavaScriptTest()
    {
        DI.NavigationHelper.NavigateToSliderPage();
        IWebElement slider = SliderPage.Slider;

        int sliderNumber =
            DI.AllureReportHelper.RunStep("Анализируем положение слайдера", () =>
            {
                return int.Parse(slider.GetAttribute("value")!);
            });

        int rndNumber = DI.FormatHelper.GetRandomNumberInt(5, 100);
        DI.AllureReportHelper.MessageInNewStep($"Двигаем на значение: {rndNumber}");

        ((IJavaScriptExecutor)DI.Driver).ExecuteScript("arguments[0].value = '100';", slider);
    }
}
