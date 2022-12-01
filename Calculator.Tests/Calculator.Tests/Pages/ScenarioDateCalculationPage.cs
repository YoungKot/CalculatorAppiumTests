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

        public WindowsElement FromDateBtn => _driver.FindElementByName("From");

        public WindowsElement Third => _driver.FindElementByName("3");

        public WindowsElement ToDateBtn => _driver.FindElementByName("To");

        public WindowsElement Sixth => _driver.FindElementByName("6");
        
        public void DifferenceBetweenDates()
        {
            // Find the buttons by their names, check the difference between dates 3rd and 6th results in 3 days
            _wait.Until(pred => FromDateBtn.Enabled);
            FromDateBtn.Click();
            Third.Click();
            ToDateBtn.Click();
            Sixth.Click();
        }
    }
}
