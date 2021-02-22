using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioStandard : Configurator
    {

        [Test]
        public void Addition()
        {
            // Find the buttons by their names and click them in sequence to perform 3 + 8 = 11
            GetCalculatorType("Standard Calculator");
            session.FindElementByName("Three").Click();
            session.FindElementByName("Plus").Click();
            session.FindElementByName("Eight").Click();
            session.FindElementByName("Equals").Click();
            Assert.AreEqual("11", GetResults("Display is", "CalculatorResults"));
        }

        [Test]
        public void Subtraction()
        {
            // Find the buttons by their accessibility ids and click them in sequence to perform 8 - 7 = 1
            GetCalculatorType("Standard Calculator");
            session.FindElementByAccessibilityId("num8Button").Click();
            session.FindElementByAccessibilityId("minusButton").Click();
            session.FindElementByAccessibilityId("num7Button").Click();
            session.FindElementByAccessibilityId("equalButton").Click();
            Assert.AreEqual("1", GetResults("Display is", "CalculatorResults"));
        }

        [Test]
        public void Division()
        {
            // Find the buttons by their names using XPath and click them in sequence to perform 55 / 11 = 5
            GetCalculatorType("Standard Calculator");
            session.FindElementByXPath("//Button[@Name='Five']").Click();
            session.FindElementByXPath("//Button[@Name='Five']").Click();
            session.FindElementByXPath("//Button[@Name='Divide by']").Click();
            session.FindElementByXPath("//Button[@Name='One']").Click();
            session.FindElementByXPath("//Button[@Name='One']").Click();
            session.FindElementByXPath("//Button[@Name='Equals']").Click();
            Assert.AreEqual("5", GetResults("Display is", "CalculatorResults"));
        }

        [Test]
        public void Multiplication()
        {
            // Find the buttons by their names and click them in sequence to perform 3 * 8 = 24
            GetCalculatorType("Standard Calculator");
            session.FindElementByName("Three").Click();
            session.FindElementByName("Multiply by").Click();
            session.FindElementByName("Eight").Click();
            session.FindElementByName("Equals").Click();
            Assert.AreEqual("24", GetResults("Display is", "CalculatorResults"));
        }
    }
}
