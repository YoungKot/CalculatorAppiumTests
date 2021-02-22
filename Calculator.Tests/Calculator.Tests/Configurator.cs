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

        public string GetResults(string text, string resultName)
        {
            result = session.FindElementByAccessibilityId(resultName);
            return result.Text.Replace(text, string.Empty).Trim();
        }

        public void GetCalculatorType(string type)
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
    }
}
