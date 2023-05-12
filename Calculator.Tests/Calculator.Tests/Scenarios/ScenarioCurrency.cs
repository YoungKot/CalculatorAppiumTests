using Calculator.Tests.Pages;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioCurrency : Session
    {

        private ScenarioCurrencyPage scenarioCurrencyPage;

        private Configurator _config;

        private readonly string calcType = "Currency Converter";

        [OneTimeSetUp]
        public void SetUp()
        {
            _config = new Configurator(session, wait);

            _config.GetCalculatorType(calcType);

            scenarioCurrencyPage = new ScenarioCurrencyPage(session, wait, _config);
        }

        [Test]
        public void ConvertFromCurrencyTest()
        {
            scenarioCurrencyPage.ConvertFromCurrency();
            Assert.AreEqual("4 United States Dollar", _config.GetResults("Convert from", "Value1"));
        }
    }
}
