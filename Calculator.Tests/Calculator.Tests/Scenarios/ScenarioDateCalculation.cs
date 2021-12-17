using Calculator.Tests.Pages;
using NUnit.Framework;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioDateCalculation : Session
    {
        private ScenarioDateCalculationPage scenarioDateCalcPage;

        [OneTimeSetUp]
        public void SetUp()
        {
            scenarioDateCalcPage = new ScenarioDateCalculationPage(session, wait);
        }

        [Test]
        public void DifferenceBetweenDatesTest()
        {
            scenarioDateCalcPage.DifferenceBetweenDates();
        }
    }
}
