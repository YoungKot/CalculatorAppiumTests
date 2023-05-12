using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;

namespace Calculator.Tests.Pages
{
    public class ScenarioCurrencyPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        private readonly WebDriverWait _wait;

        private readonly Configurator _config;

        public ScenarioCurrencyPage(WindowsDriver<WindowsElement> driver, WebDriverWait wait, Configurator config)
        {
            _driver = driver;
            _wait = wait;
            _config = config;
        }

        private WindowsElement Unit1 => _driver.FindElementByAccessibilityId("Units1");

        private WindowsElement CurrencyToBeConverted => _driver.FindElementByAccessibilityId("Units1");

        private WindowsElement CurrencyConverted => _driver.FindElementByAccessibilityId("Units2");

        private WindowsElement DollarCurrency => _driver.FindElementByName("United States Dollar");

        private WindowsElement EuroCurrency => _driver.FindElementByName("Europe Euro");

        private WindowsElement ConvertButton => _driver.FindElementByAccessibilityId("num4Button");

        public void ConvertFromCurrency()
        {
            _wait.Until(pred => Unit1.Displayed);
            if (!CurrencyToBeConverted.Text.Contains("United States"))
            {
                _config.WaitAndClick(Unit1.Text);
                DollarCurrency.Click();
            }
            if (!CurrencyConverted.Text.Contains("Europe Euro"))
            {
                _config.WaitAndClick("Units2");
                EuroCurrency.Click();
            }
            ConvertButton.Click();
        }
    }
}
