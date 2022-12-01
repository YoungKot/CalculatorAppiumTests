using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace Calculator.Tests.Pages
{
    public class ScenarioStandardPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        private readonly WebDriverWait _wait;

        private readonly Configurator _config;

        public ScenarioStandardPage(WindowsDriver<WindowsElement> driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public WindowsElement BtnEight => _driver.FindElementByName("Eight");

        public WindowsElement BtnPlus => _driver.FindElementByName("Plus");

        public WindowsElement BtnThree => _driver.FindElementByName("Three");

        public WindowsElement BtnEquals => _driver.FindElementByName("Equals");

        public WindowsElement BtnMultiply => _driver.FindElementByName("Multiply by");

        public WindowsElement BtnSeven => _driver.FindElementByName("Seven");

        public WindowsElement BtnMinus => _driver.FindElementByAccessibilityId("minusButton");

        public WindowsElement BtnFive => _driver.FindElementByXPath("//Button[@Name='Five']");

        public WindowsElement BtnDivide => _driver.FindElementByXPath("//Button[@Name='Divide by']");

        public WindowsElement BtnOne => _driver.FindElementByXPath("//Button[@Name='One']");

        public void Addition()
        {
            // Find the buttons by their names and click them in sequence to perform 3 + 8 = 11
            _wait.Until(pred => BtnThree.Displayed);
            BtnThree.Click();
            BtnPlus.Click();
            BtnEight.Click();
            BtnEquals.Click();
        }

        public void Subtraction()
        {
            // Find the buttons by their accessibility ids and click them in sequence to perform 8 - 7 = 1
            _wait.Until(pred => BtnSeven.Displayed);
            BtnEight.Click();
            BtnMinus.Click();
            BtnSeven.Click();
            BtnEquals.Click();
        }

        public void Division()
        {
            // Find the buttons by their names using XPath and click them in sequence to perform 55 / 11 = 5
            _wait.Until(pred => BtnFive.Displayed);
            BtnFive.Click();
            BtnFive.Click();
            BtnDivide.Click();
            BtnOne.Click();
            BtnOne.Click();
            BtnEquals.Click();
        }

        public void Multiplication()
        {
            // Find the buttons by their names and click them in sequence to perform 3 * 8 = 24
            _wait.Until(pred => BtnThree.Displayed);
            BtnThree.Click();
            BtnMultiply.Click();
            BtnEight.Click();
            BtnEquals.Click();
        }
    }
}
