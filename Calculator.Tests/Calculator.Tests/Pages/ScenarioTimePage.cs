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
    public class ScenarioTimePage
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        private readonly WebDriverWait _wait;

        private Configurator _config;

        private string calcType = "Time Converter";

        public ScenarioTimePage(WindowsDriver<WindowsElement> driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            _config = new Configurator(driver, wait);
            _config.GetCalculatorType(calcType);
        }

        public WindowsElement Unit1 => _driver.FindElementByAccessibilityId("Units1");

        public WindowsElement Unit2 => _driver.FindElementByAccessibilityId("Units2");

        public void ConvertFromMinutesToSeconds()
        {
            // Find the labels by their accessibility ids and names, check for the time values present and get the value to be converted from 8 minutes in 480 seconds
            ConfigureTime("Minutes", "Seconds", "Eight");
            Assert.AreEqual("480 Seconds", _config.GetResults("Converts into", "Value2"));
        }

        public void ConvertFromWeeksToDays()
        {
            // Find the labels by their accessibility ids and names, check for the time values present and get the value to be converted from 5 weeks to 35 days
            ConfigureTime("Weeks", "Days", "Five");
            Assert.AreEqual("35 Days", _config.GetResults("Converts into", "Value2"));
        }

        public void ConvertFromHoursToMinutes()
        {
            // Find the labels by their accessibility ids and names, check for the time values present and get the value to be converted from 2 hours to 120 minutes
            ConfigureTime("Hours", "Minutes", "Two");
            Assert.AreEqual("120 Minutes", _config.GetResults("Converts into", "Value2"));
        }

        private void ConfigureTime(string input, string output, string button)
        {
            try
            {
                _wait.Until(pred => Unit1.Displayed);
                string from = Unit1.Text;
                string to = Unit2.Text;
                if (!from.Contains(input))
                {
                    _config.WaitAndClick("Units1");
                    _driver.FindElementByName(input).Click();
                }
                if (!to.Contains(output))
                {
                    _config.WaitAndClick("Units2");
                    _driver.FindElementByName(output).Click();
                }
                _driver.FindElementByName(button).Click();
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException($"All of the parameters are of the type element name. {ex}");
            }
        }
    }
}
