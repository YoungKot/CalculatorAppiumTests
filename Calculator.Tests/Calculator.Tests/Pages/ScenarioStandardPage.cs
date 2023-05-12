using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace Calculator.Tests.Pages
{
    public class ScenarioStandardPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        private readonly WebDriverWait _wait;

        public ScenarioStandardPage(WindowsDriver<WindowsElement> driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private WindowsElement EightButton => _driver.FindElementByName("Eight");

        private WindowsElement PlusButton => _driver.FindElementByName("Plus");

        private WindowsElement ThreeButton => _driver.FindElementByName("Three");

        private WindowsElement EqualsButton => _driver.FindElementByName("Equals");

        private WindowsElement MultiplyButton => _driver.FindElementByName("Multiply by");

        private WindowsElement SevenButton => _driver.FindElementByName("Seven");

        private WindowsElement MinusButton => _driver.FindElementByAccessibilityId("minusButton");

        private WindowsElement FiveButton => _driver.FindElementByXPath("//Button[@Name='Five']");

        private WindowsElement DivideButton => _driver.FindElementByXPath("//Button[@Name='Divide by']");

        private WindowsElement OneButton => _driver.FindElementByXPath("//Button[@Name='One']");

        public void Addition()
        {
            // Find the buttons by their names and click them in sequence to perform 3 + 8 = 11
            _wait.Until(pred => ThreeButton.Displayed);
            ThreeButton.Click();
            PlusButton.Click();
            EightButton.Click();
            EqualsButton.Click();
        }

        public void Subtraction()
        {
            // Find the buttons by their accessibility ids and click them in sequence to perform 8 - 7 = 1
            _wait.Until(pred => SevenButton.Displayed);
            EightButton.Click();
            MinusButton.Click();
            SevenButton.Click();
            EqualsButton.Click();
        }

        public void Division()
        {
            // Find the buttons by their names using XPath and click them in sequence to perform 55 / 11 = 5
            _wait.Until(pred => FiveButton.Displayed);
            FiveButton.Click();
            FiveButton.Click();
            DivideButton.Click();
            OneButton.Click();
            OneButton.Click();
            EqualsButton.Click();
        }

        public void Multiplication()
        {
            // Find the buttons by their names and click them in sequence to perform 3 * 8 = 24
            _wait.Until(pred => ThreeButton.Displayed);
            ThreeButton.Click();
            MultiplyButton.Click();
            EightButton.Click();
            EqualsButton.Click();
        }
    }
}
