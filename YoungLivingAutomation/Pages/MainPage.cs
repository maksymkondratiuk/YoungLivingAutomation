using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungLivingAutomation.Pages
{
    /// <summary>
	/// Represent Main page 
	/// </summary>
    public class MainPage : BasePage
    {

		private IWebDriver driver;

		[FindsBy(How = How.CssSelector, Using = "[data-testid='qa-myaccount']")]
		public IWebElement signinLink;

        [FindsBy(How = How.Id, Using = "searchInput")]
        public IWebElement searchTextBox;

        public MainPage(IWebDriver driver) : base(driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}

        /// <summary>
        /// Click SighIn button on Main page
        /// </summary>
        public LoginPage clickSigninLink()
		{
			signinLink.Click();
			return new LoginPage(driver);
		}

        /// <summary>
        /// Method to search for product using searchbox
        /// </summary>
        /// <param name="productName">Name of product to search.</param>
        public SearchProductsPage searchForProduct(String productName)
        {
            searchTextBox.Click();
            searchTextBox.SendKeys(productName);
            searchTextBox.SendKeys(Keys.Enter);
            return new SearchProductsPage(driver);
        }

        /// <summary>
        /// Waiter for Main page
        /// </summary>
        public MainPage waitForMainPageToLoad()
        {
            WaitForElementToLoad(By.CssSelector("#Shop"));
            return this;
        }
    }
}
