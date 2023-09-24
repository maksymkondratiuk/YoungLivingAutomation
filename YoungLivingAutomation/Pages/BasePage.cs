using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungLivingAutomation.Pages
{
    /// <summary>
    /// Base class for pages
    /// </summary>
    public class BasePage
    {
		private IWebDriver driver;

		public BasePage(IWebDriver driver)
		{
			this.driver = driver;
		}

		public MainPage homePage()
		{
			return new MainPage(driver);
		}

		public LoginPage signInPage()
		{
			return new LoginPage(driver);
		}

        /// <summary>
		/// Basic waiter method
		/// </summary>
        /// <param name="locator">Locator for element.</param>
        public void WaitForElementToLoad(By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Func<IWebDriver, bool> condition = (d) =>
            {
                try
                {
                    return d.FindElement(locator).Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            };

            wait.Until(condition);
        }
    }
}
