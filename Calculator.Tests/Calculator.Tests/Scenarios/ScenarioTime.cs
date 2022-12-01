using Calculator.Tests.Pages;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioTime : Session
    {
        private ScenarioTimePage scenarioTimePage;

        private Configurator _config;

        private string calcType = "Time Converter";

        [OneTimeSetUp]
        public void SetUp()
        {
            _config = new Configurator(session, wait);
            _config.GetCalculatorType(calcType);
            scenarioTimePage = new ScenarioTimePage(session, wait, _config);
        }

        [Test]
        public void ConvertFromMinutesToSecondsTest()
        {
            scenarioTimePage.ConvertFromMinutesToSeconds();
            Assert.AreEqual("480 Seconds", _config.GetResults("Converts into", "Value2"));
        }

        [Test]
        public void ConvertFromWeeksToDaysTest()
        {
            scenarioTimePage.ConvertFromWeeksToDays();
            Assert.AreEqual("35 Days", _config.GetResults("Converts into", "Value2"));
        }

        [Test]
        public void ConvertFromHoursToMinutesTest()
        {
            scenarioTimePage.ConvertFromHoursToMinutes();
            Assert.AreEqual("120 Minutes", _config.GetResults("Converts into", "Value2"));
        }
    }
}
