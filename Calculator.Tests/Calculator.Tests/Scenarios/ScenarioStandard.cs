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
            scenarioStandardPage.Addition();
        }

        [Test]
        public void SubtractionTest()
        {
            scenarioStandardPage.Subtraction();
        }

        [Test]
        public void DivisionTest()
        {
            scenarioStandardPage.Division();
        }

        [Test]
        public void MultiplicationTest()
        {
            scenarioStandardPage.Multiplication();
        }
    }
}
