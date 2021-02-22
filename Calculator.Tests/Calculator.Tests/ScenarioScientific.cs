﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public class ScenarioScientific : Configurator
    {   
        [Test]
        public void Exponent()
        {
            // Find the buttons by their names and accessibility ids and click them in sequence to perform 2 in the power of 3 = 8
            GetCalculatorType("Scientific Calculator");
            session.FindElementByName("Two").Click();
            session.FindElementByAccessibilityId("powerButton").Click();
            session.FindElementByName("Three").Click();
            session.FindElementByName("Equals").Click();
            Assert.AreEqual("8", GetResults("Display is", "CalculatorResults"));
        }

        [Test]
        public void Mod()
        {
            // Find the buttons by their names and accessibility ids and click them in sequence to perform 10 mod 3 = 1
            GetCalculatorType("Scientific Calculator");
            session.FindElementByName("One").Click();
            session.FindElementByName("Zero").Click();
            session.FindElementByAccessibilityId("modButton").Click();
            session.FindElementByName("Three").Click();
            session.FindElementByName("Equals").Click();
            Assert.AreEqual("1", GetResults("Display is", "CalculatorResults"));
        }
    }
}