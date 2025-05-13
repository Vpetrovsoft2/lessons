using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Autotests.UITests
{
    public class Tests : BaseTests
    {
        [Test]
        public void Test1()
        {
            DI.Driver.FindElement(By.XPath("//h5[text()='Elements']"));

            var forms = DI.Driver.FindElement(By.XPath("//h5[text()='Forms']"));
            forms.Click();

            var practiceForm = DI.Driver.FindElement(By.XPath("//span[text()='Practice Form']"));
            practiceForm.Click();

            var userName = DI.Driver.FindElement(By.CssSelector($"input[id='firstName']"));
            userName.SendKeys("Vitya");

        }

        [Test]
        public void Test2()
        {
            DI.Driver.FindElement(By.XPath("//h5[text()='Elements']"));

        }


        /* 
         CSS-���������
         ��������           ������
         tag               input, button, div
         ID                id="15"  ||   #15
         class             class="True_class"  || .True_class
         attribute         placeholder="Current Address"
         
         ����������        div[id='g']
         ��������� ������� .class1.class2
         �������� > �������  parent > child  ||  div > input
         ������������       div:nth-child(2) || first-child

         
         XPath - �������

         /html/body/div[2]/div/div/div[2]/div/div[1]/div/div[3]/h5

         //*[@id="app"]/../div/div[3]/h5
         */

    }
}