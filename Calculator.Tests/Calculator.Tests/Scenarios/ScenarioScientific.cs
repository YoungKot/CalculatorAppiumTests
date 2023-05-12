using Calculator.Tests.Pages;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioScientific : Session
    {
        private ScenarioScientificPage scenarioScientificPage;
        
        private Configurator _config;

        private readonly string calcType = "Scientific Calculator";

        [OneTimeSetUp]
        public void SetUp()
        {
            _config = new Configurator(session, wait);
            _config.GetCalculatorType(calcType);
            scenarioScientificPage = new ScenarioScientificPage(session, wait);
        }

        [Test]
        public void ExponentTest()
        {
            scenarioScientificPage.Exponent();
            Assert.AreEqual("8", _config.GetResults("Display is", "CalculatorResults"));
        }

        [Test]
        public void ModTest()
        {
            scenarioScientificPage.Mod();
            Assert.AreEqual("1", _config.GetResults("Display is", "CalculatorResults"));
        }
    }
}
