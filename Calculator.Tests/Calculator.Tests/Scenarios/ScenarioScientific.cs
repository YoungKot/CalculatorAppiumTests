using Calculator.Tests.Pages;
using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioScientific : Session
    {
        private ScenarioScientificPage scenarioScientificPage;

        [OneTimeSetUp]
        public void SetUp()
        {
            scenarioScientificPage = new ScenarioScientificPage(session, wait);
        }

        [Test]
        public void ExponentTest()
        {
            scenarioScientificPage.Exponent();
        }

        [Test]
        public void ModTest()
        {
            scenarioScientificPage.Mod();
        }
    }
}
