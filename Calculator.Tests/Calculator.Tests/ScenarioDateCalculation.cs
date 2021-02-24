using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    public class ScenarioDateCalculation : Configurator
    {
        [Test]
        public void DifferenceBetweenDates()
        {
            // Find the buttons by their names, check the difference between dates 3rd and 6th results in 3 days
            GetCalculatorType("Date Calculation Calculator");
            wait.Until(pred => session.FindElementByName("From").Displayed);
            session.FindElementByName("From").Click();
            session.FindElementByName("3").Click();
            session.FindElementByName("To").Click();
            session.FindElementByName("6").Click();
            Assert.AreEqual("3", GetResults("days", "DateDiffAllUnitsResultLabel"));
        }
    }
}
