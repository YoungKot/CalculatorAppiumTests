using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public class ScenarioTime : Configurator
    {
        [Test]
        public void ConvertFromHoursToMinutes()
        {
            // Find the labels by their accessibility ids and names, check for the time values present and get the value to be converted from 5 hours in 300 minutes
            GetCalculatorType("Time Converter");
            string input = session.FindElementByAccessibilityId("Units1").Text;
            string output = session.FindElementByAccessibilityId("Units2").Text;
            if (!input.Contains("Hours"))
            {
                session.FindElementByAccessibilityId("Units1").Click();
                session.FindElementByName("Hours").Click();
            }
            if (!output.Contains("Minutes"))
            {
                session.FindElementByAccessibilityId("Units2").Click();
                session.FindElementByName("Minutes").Click();
            }
            session.FindElementByAccessibilityId("num5Button").Click();
            Assert.AreEqual("300 Minutes", GetResults("Converts into", "Value2"));
        }

        [Test]
        public void ConvertFromWeeksToDays()
        {
            // Find the labels by their accessibility ids and names, check for the time values present and get the value to be converted from 5 weeks to 35 days
            GetCalculatorType("Time Converter");
            string input = session.FindElementByAccessibilityId("Units1").Text;
            string output = session.FindElementByAccessibilityId("Units2").Text;
            if (!input.Contains("Weeks"))
            {
                session.FindElementByAccessibilityId("Units1").Click();
                session.FindElementByName("Weeks").Click();
            }
            if (!output.Contains("Days"))
            {
                session.FindElementByAccessibilityId("Units2").Click();
                session.FindElementByName("Days").Click();
            }
            session.FindElementByAccessibilityId("num5Button").Click();
            Assert.AreEqual("35 Days", GetResults("Converts into", "Value2"));
        }

        [Test]
        public void ConvertFromWeeksToHours()
        {
            // Find the labels by their accessibility ids and names, check for the time values present and get the value to be converted from 2 weeks to 8,736 hours
            GetCalculatorType("Time Converter");
            string input = session.FindElementByAccessibilityId("Units1").Text;
            string output = session.FindElementByAccessibilityId("Units2").Text;
            if (!input.Contains("Weeks"))
            {
                session.FindElementByAccessibilityId("Units1").Click();
                session.FindElementByName("Weeks").Click();
            }
            if (!output.Contains("Hours"))
            {
                session.FindElementByAccessibilityId("Units2").Click();
                session.FindElementByName("Hours").Click();
            }
            session.FindElementByAccessibilityId("num2Button").Click();
            Assert.AreEqual("8,736 Hours", GetResults("Converts into", "Value2"));
        }
    }
}
