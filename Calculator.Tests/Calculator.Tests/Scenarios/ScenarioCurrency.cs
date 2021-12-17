using Calculator.Tests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioCurrency : Session
    {

        private ScenarioCurrencyPage scenarioCurrencyPage;

        [OneTimeSetUp]
        public void SetUp()
        {
            scenarioCurrencyPage = new ScenarioCurrencyPage(session, wait);
        }

        [Test]
        public void ConvertFromCurrencyTest()
        {
            scenarioCurrencyPage.ConvertFromCurrency();
        }
    }
}
