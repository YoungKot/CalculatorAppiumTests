using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    public class ScenarioCurrency : Configurator
    {
        [Test]
        public void ConvertFromCurrency()
        {
            // Find the buttons by their accessibility ids, check for the currency values present and get the value to be converted from - 4
            GetCalculatorType("Currency Converter");
            string currencyToBeConverted = session.FindElementByAccessibilityId("Units1").Text;
            string currencyConverted = session.FindElementByAccessibilityId("Units2").Text;
            if (!currencyToBeConverted.Contains("United States"))
            {
                session.FindElementByName("United States Dollar").Click();
            }
            if (!currencyConverted.Contains("Europe Euro"))
            {
                session.FindElementByName("Europe Euro").Click();
            }
            session.FindElementByAccessibilityId("num4Button").Click();
            Assert.AreEqual("4 United States Dollar", GetResults("Convert from", "Value1"));
        }
    }
}
