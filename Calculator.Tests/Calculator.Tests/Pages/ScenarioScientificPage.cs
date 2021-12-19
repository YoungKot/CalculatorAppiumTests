﻿using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests.Pages
{
    public class ScenarioScientificPage
    {
        private readonly WindowsDriver<WindowsElement> _driver;

        private readonly WebDriverWait _wait;

        private Configurator _config;

        private string calcType = "Scientific Calculator";

        public ScenarioScientificPage(WindowsDriver<WindowsElement> driver, WebDriverWait wait)
        {
            _driver = driver;
            _wait = wait;
            _config = new Configurator(_driver, _wait);
            _config.GetCalculatorType(calcType);
        }

        public WindowsElement BtnOne => _driver.FindElementByName("One");

        public WindowsElement BtnTwo => _driver.FindElementByName("Two");

        public WindowsElement BtnZero => _driver.FindElementByName("Zero");

        public WindowsElement BtnThree => _driver.FindElementByName("Three");

        public WindowsElement BtnEquals => _driver.FindElementByName("Equals");

        public WindowsElement BtnPower => _driver.FindElementByAccessibilityId("powerButton");

        public WindowsElement BtnMod => _driver.FindElementByAccessibilityId("modButton");
        public void Exponent()
        {
            // Find the buttons by their names and accessibility ids and click them in sequence to perform 2 in the power of 3 = 8
            _wait.Until(pred => BtnTwo.Displayed);
            BtnTwo.Click();
            BtnPower.Click();
            BtnThree.Click();
            BtnEquals.Click();
            Assert.AreEqual("8", _config.GetResults("Display is", "CalculatorResults"));
        }

        public void Mod()
        {
            // Find the buttons by their names and accessibility ids and click them in sequence to perform 10 mod 3 = 1
            _wait.Until(pred => BtnOne.Displayed);
            BtnOne.Click();
            BtnZero.Click();
            BtnMod.Click();
            BtnThree.Click();
            BtnEquals.Click();
            Assert.AreEqual("1", _config.GetResults("Display is", "CalculatorResults"));
        }
    }
}
