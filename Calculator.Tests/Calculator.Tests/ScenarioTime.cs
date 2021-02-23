using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    public class ScenarioTime : Configurator
    {
        [Test]
        public void ConvertFromMinutesToSeconds()
        {
            // Find the labels by their accessibility ids and names, check for the time values present and get the value to be converted from 8 minutes in 480 seconds
            ConfigureTime("Minutes", "Seconds", "Eight");
            Assert.AreEqual("480 Seconds", GetResults("Converts into", "Value2"));
        }

        [Test]
        public void ConvertFromWeeksToDays()
        {
            // Find the labels by their accessibility ids and names, check for the time values present and get the value to be converted from 5 weeks to 35 days
            ConfigureTime("Weeks", "Days", "Five");
            Assert.AreEqual("35 Days", GetResults("Converts into", "Value2"));
        }

        [Test]
        public void ConvertFromHoursToMinutes()
        {
            // Find the labels by their accessibility ids and names, check for the time values present and get the value to be converted from 2 hours to 120 minutes
            ConfigureTime("Hours", "Minutes", "Two");
            Assert.AreEqual("120 Minutes", GetResults("Converts into", "Value2"));
        }

        private void ConfigureTime(string input, string output, string button)
        {
            try
            {
                GetCalculatorType("Time Converter");
                string from = session.FindElementByAccessibilityId("Units1").Text;
                string to = session.FindElementByAccessibilityId("Units2").Text;
                if (!from.Contains(input))
                {
                    session.FindElementByAccessibilityId("Units1").Click();
                    session.FindElementByName(input).Click();
                }
                if (!to.Contains(output))
                {
                    session.FindElementByAccessibilityId("Units2").Click();
                    session.FindElementByName(output).Click();
                }
                session.FindElementByName(button).Click();
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }
            catch(InvalidOperationException ex)
            {
                throw new InvalidOperationException($"All of the parameters are of the type element name. {ex}");
            }
        }
    }
}
