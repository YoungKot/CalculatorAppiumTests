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
    public class ScenarioDateCalculationPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        private readonly WebDriverWait _wait;

        private Configurator _config;

        private string calcType = "Date Calculation Calculator";

        public ScenarioDateCalculationPage(WindowsDriver<WindowsElement> driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            _config = new Configurator(_driver, _wait);
            _config.GetCalculatorType(calcType);
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
            Assert.AreEqual("3", _config.GetResults("days", "DateDiffAllUnitsResultLabel"));
        }
    }
}
