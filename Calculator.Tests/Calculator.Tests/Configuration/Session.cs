﻿using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;

namespace Calculator.Tests
{
    public class Session
    {
        // test must be directed at Appium
        private static string WindowsApplicationDriverUrl = "http://127.0.0.1:4723/wd/hub";
        private static string CalculatorAppId = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
        public static WindowsDriver<WindowsElement> session;
        public static WebDriverWait wait;

        [OneTimeSetUp]
        public static void Setup()
        {
            // Launch Calculator application if it is not yet launched
            if (session == null)
            {
                // Create a new session to bring up an instance of the Calculator application
                AppiumOptions desiredCapabilities = new AppiumOptions();
                desiredCapabilities.AddAdditionalCapability("app", CalculatorAppId);
                desiredCapabilities.AddAdditionalCapability("deviceName", "WindowsPC");
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), desiredCapabilities);

                // Set explicit timeout to 10 seconds to make element search to retry every 250 ms
                wait = new WebDriverWait(session, TimeSpan.FromSeconds(10));

            }
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            // Close the application and delete the session
            if (session != null)
            {
                session.Quit();
                session = null;
            }
        }

    }
}
