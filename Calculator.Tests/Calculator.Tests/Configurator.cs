using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public class Configurator : Session
    {
        private static string header;
        private static WindowsElement result;
        
        // Concate the text
        public static string GetResults(string text, string resultName)
        {
            try
            {
                result = session.FindElementByAccessibilityId(resultName);
                return result.Text.Replace(text, string.Empty).Trim();
            }
            catch(InvalidOperationException ex)
            {
                throw new InvalidOperationException($"resultName must be of the type AccessibilityId. {ex}");
            }
        }

        // Check the header of the calculator, switch it if no match between header and type
        public static void GetCalculatorType(string type)
        {
            try
            {
                header = session.FindElementByAccessibilityId("Header").Text;

                if (!type.Contains(header))
                {
                    var paneButton = session.FindElementByAccessibilityId("TogglePaneButton");
                    wait.Until(pred => paneButton.Displayed);
                    paneButton.Click();
                    var calcType = session.FindElementByName(type);
                    wait.Until(pred => calcType.Displayed);
                    calcType.Click();
                }
            }
            catch(InvalidOperationException ex)
            {
                throw new InvalidOperationException($"The type must be of the type element name. {ex}");
            }

        }

        // Wait until element is displayed and then click on it
        public static void WaitAndClick(string AccessibilityId)
        {
            var element = session.FindElementByAccessibilityId(AccessibilityId);
            wait.Until(pred => element.Displayed);
            element.Click();
        }
    }
}
