using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.Pages
{
    public class ScenarioCurrencyPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        private readonly WebDriverWait _wait;

        private Configurator _config;

        private string calcType = "Currency Converter";

        public ScenarioCurrencyPage(WindowsDriver<WindowsElement> driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            _config =  new Configurator(driver, wait);
            _config.GetCalculatorType(calcType);
        }

        public WindowsElement Unit1 => _driver.FindElementByAccessibilityId("Units1");

        public WindowsElement CurrencyToBeConverted => _driver.FindElementByAccessibilityId("Units1");

        public WindowsElement CurrencyConverted => _driver.FindElementByAccessibilityId("Units2");

        public WindowsElement DollarCurrency => _driver.FindElementByName("United States Dollar");

        public WindowsElement EuroCurrency => _driver.FindElementByName("Europe Euro");

        public WindowsElement ConvertButton => _driver.FindElementByAccessibilityId("num4Button");

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
            Assert.AreEqual("4 United States Dollar", _config.GetResults("Convert from", "Value1"));
        }
    }
}
