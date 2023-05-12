using Calculator.Tests.Pages;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioStandard : Session
    {
        private ScenarioStandardPage scenarioStandardPage;

        private Configurator _config;

        private readonly string calcType = "Standard Calculator";    

        [OneTimeSetUp]
        public void SetUp()
        {
            _config = new Configurator(session, wait);
            _config.GetCalculatorType(calcType);
            scenarioStandardPage = new ScenarioStandardPage(session, wait);
        }

        [Test]
        public void AdditionTest()
        {
            scenarioStandardPage.Addition();
            Assert.AreEqual("11", _config.GetResults("Display is", "CalculatorResults"));
        }

        [Test]
        public void SubtractionTest()
        {
            scenarioStandardPage.Subtraction();
            Assert.AreEqual("1", _config.GetResults("Display is", "CalculatorResults"));
        }

        [Test]
        public void DivisionTest()
        {
            scenarioStandardPage.Division();
            Assert.AreEqual("5", _config.GetResults("Display is", "CalculatorResults"));
        }

        [Test]
        public void MultiplicationTest()
        {
            scenarioStandardPage.Multiplication();
            Assert.AreEqual("24", _config.GetResults("Display is", "CalculatorResults"));
        }
    }
}
