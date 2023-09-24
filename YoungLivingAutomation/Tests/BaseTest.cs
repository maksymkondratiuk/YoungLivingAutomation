using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungLivingAutomation.Tests
{
    /// <summary>
    /// Base class for tests
    /// </summary>
    public class BaseTest
    {
        public static IWebDriver driver { get; set; }

        /// <summary>
        /// Set up method to init options and start driver
        /// </summary>
        [SetUp]
        public void SetupTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.youngliving.com/us/en/");
        }

        /// <summary>
        /// TearDown method to close driver after test
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
