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
	/// Represent page with search results
	/// </summary>
	public class SearchProductsPage : BasePage
    {
        private IWebDriver driver;

		[FindsBy(How = How.CssSelector, Using = "[data-testid='qa-quick-shop']")]
		public IWebElement addToCardButton;

		[FindsBy(How = How.CssSelector, Using = "[data-testid='qa-cartcheckout']")]
		public IWebElement viewCartButton;

		public SearchProductsPage(IWebDriver driver) : base(driver)
		{
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

		/// <summary>
		/// Waiter for products after search
		/// </summary>
		public SearchProductsPage waitForProductsScreenToLoad()
		{
			WaitForElementToLoad(By.CssSelector("[data-testid='qa-quick-shop']"));
			return this;
		}

		/// <summary>
		/// Waiter for shoppint cart
		/// </summary>
		public SearchProductsPage waitForShoppingCartToLoad()
		{
			WaitForElementToLoad(By.Id("minicart-title"));
			return this;
		}

		/// <summary>
		/// Click add to cart button
		/// </summary>
		public SearchProductsPage clickAddToCart()
		{
			addToCardButton.Click();
			return this;
		}

		/// <summary>
		/// Click view cart button
		/// </summary>
		public ViewCartPage clickViewCartButton()
		{
			viewCartButton.Click();
			return new ViewCartPage(driver);
		}
	}
}
