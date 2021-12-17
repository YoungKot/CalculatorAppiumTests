using System;
using Calculator.Tests.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioStandard : Session
    {
        private ScenarioStandardPage scenarioStandardPage;

        [OneTimeSetUp]
        public void SetUp()
        {
            scenarioStandardPage = new ScenarioStandardPage(session, wait);
        }

        [Test]
        public void AdditionTest()
        {
            // Find the buttons by their names and click them in sequence to perform 3 + 8 = 11
            scenarioStandardPage.Addition();
        }

        [Test]
        public void SubtractionTest()
        {
            // Find the buttons by their accessibility ids and click them in sequence to perform 8 - 7 = 1
            scenarioStandardPage.Subtraction();
        }

        [Test]
        public void DivisionTest()
        {
            // Find the buttons by their names using XPath and click them in sequence to perform 55 / 11 = 5
            scenarioStandardPage.Division();
        }

        [Test]
        public void MultiplicationTest()
        {
            // Find the buttons by their names and click them in sequence to perform 3 * 8 = 24
            scenarioStandardPage.Multiplication();
        }
    }
}
