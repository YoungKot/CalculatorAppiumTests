using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace Calculator.Tests.Pages
{
    public class ScenarioScientificPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        private readonly WebDriverWait _wait;

        public ScenarioScientificPage(WindowsDriver<WindowsElement> driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private WindowsElement OneButton => _driver.FindElementByName("One");

        private WindowsElement TwoButton => _driver.FindElementByName("Two");

        private WindowsElement ZeroButton => _driver.FindElementByName("Zero");

        private WindowsElement ThreeButton => _driver.FindElementByName("Three");

        private WindowsElement EqualsButton => _driver.FindElementByName("Equals");

        private WindowsElement PowerButton => _driver.FindElementByAccessibilityId("powerButton");

        private WindowsElement ModButton => _driver.FindElementByAccessibilityId("modButton");

        public void Exponent()
        {
            // Find the buttons by their names and accessibility ids and click them in sequence to perform 2 in the power of 3 = 8
            _wait.Until(pred => TwoButton.Displayed);
            TwoButton.Click();
            PowerButton.Click();
            ThreeButton.Click();
            EqualsButton.Click();
        }

        public void Mod()
        {
            // Find the buttons by their names and accessibility ids and click them in sequence to perform 10 mod 3 = 1
            _wait.Until(pred => OneButton.Displayed);
            OneButton.Click();
            ZeroButton.Click();
            ModButton.Click();
            ThreeButton.Click();
            EqualsButton.Click();
        }
    }
}
