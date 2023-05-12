using Calculator.Tests.Pages;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioDateCalculation : Session
    {
        private ScenarioDateCalculationPage scenarioDateCalcPage;

        private Configurator _config;

        private reaonly string calcType = "Date Calculation Calculator";

        [OneTimeSetUp]
        public void SetUp()
        {
            _config = new Configurator(session, wait);

            _config.GetCalculatorType(calcType);

            scenarioDateCalcPage = new ScenarioDateCalculationPage(session, wait);
        }

        [Test]
        public void DifferenceBetweenDatesTest()
        {
            scenarioDateCalcPage.DifferenceBetweenDates();
            Assert.AreEqual("3", _config.GetResults("days", "DateDiffAllUnitsResultLabel"));
        }
    }
}
