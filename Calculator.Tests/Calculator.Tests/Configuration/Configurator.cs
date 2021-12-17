using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public class Configurator
    {
        private WindowsElement result;
        private readonly WindowsDriver<WindowsElement> _driver;
        private readonly WebDriverWait _wait;
        public Configurator(WindowsDriver<WindowsElement> driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
        }

        public WindowsElement Header => _driver.FindElementByAccessibilityId("Header");
        public WindowsElement paneButton => _driver.FindElementByAccessibilityId("TogglePaneButton");

        // Concate the text
        public string GetResults(string text, string resultName)
        {
            try
            {
                result = _driver.FindElementByAccessibilityId(resultName);
                return result.Text.Replace(text, string.Empty).Trim();
            }
            catch(InvalidOperationException ex)
            {
                throw new InvalidOperationException($"resultName must be of the type AccessibilityId. {ex}");
            }
        }

        // Check the header of the calculator, switch it if no match between header and type
        public void GetCalculatorType(string type)
        {
            try
            {
                if (!type.Contains(Header.Text))
                {
                    _wait.Until(pred => paneButton.Displayed);
                    paneButton.Click();
                    var calcType = _driver.FindElementByName(type);
                    _wait.Until(pred => calcType.Displayed);
                    calcType.Click();
                }
            }
            catch(InvalidOperationException ex)
            {
                throw new InvalidOperationException($"The type must be of the type element name. {ex}");
            }

        }

        // Wait until element is displayed and then click on it
        public void WaitAndClick(string AccessibilityId)
        {
            var element = _driver.FindElementByAccessibilityId(AccessibilityId);
            _wait.Until(pred => element.Displayed);
            element.Click();
        }
    }
}
