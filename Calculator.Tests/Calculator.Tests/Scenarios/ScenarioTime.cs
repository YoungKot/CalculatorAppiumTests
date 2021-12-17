using Calculator.Tests.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class ScenarioTime : Session
    {
        private ScenarioTimePage scenarioTimePage;

        [OneTimeSetUp]
        public void SetUp()
        {
            scenarioTimePage = new ScenarioTimePage(session, wait);
        }

        [Test]
        public void ConvertFromMinutesToSecondsTest()
        {
            scenarioTimePage.ConvertFromMinutesToSeconds();
        }

        [Test]
        public void ConvertFromWeeksToDaysTest()
        {
            scenarioTimePage.ConvertFromWeeksToDays();
        }

        [Test]
        public void ConvertFromHoursToMinutesTest()
        {
            scenarioTimePage.ConvertFromHoursToMinutes();
        }
    }
}
