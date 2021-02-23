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
            catch(Exception ex)
            {
                throw new InvalidOperationException("resultName must be of the type AccessibilityId.");
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
                    session.FindElementByAccessibilityId("TogglePaneButton").Click();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    session.FindElementByName(type).Click();
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException("The type must be of the type element name.");
            }

        }
    }
}
