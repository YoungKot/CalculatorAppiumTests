using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace Calculator.Tests.Pages
{
    public class ScenarioDateCalculationPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        private readonly WebDriverWait _wait;

        public ScenarioDateCalculationPage(WindowsDriver<WindowsElement> driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        private WindowsElement FromDateButton => _driver.FindElementByName("From");

        private WindowsElement Third => _driver.FindElementByName("3");

        private WindowsElement ToDateButton => _driver.FindElementByName("To");

        private WindowsElement Sixth => _driver.FindElementByName("6");
        
        public void DifferenceBetweenDates()
        {
            // Find the buttons by their names, check the difference between dates 3rd and 6th results in 3 days
            _wait.Until(pred => FromDateButton.Enabled);
            FromDateButton.Click();
            Third.Click();
            ToDateButton.Click();
            Sixth.Click();
        }
    }
}
