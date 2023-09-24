using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungLivingAutomation.Pages
{
    public class ViewCartPage : BasePage
    {
        private IWebDriver driver;

        public ViewCartPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[data-testid='qa-cart-checkout']")]
        public IWebElement checkoutButton;

        public ViewCartPage waitForViewCartToLoad()
        {
            WaitForElementToLoad(By.CssSelector("[data-testid='qa-cart-checkout']"));
            return this;
        }

        public CheckoutPage clickCheckoutButton()
        {
            checkoutButton.Click();
            return new CheckoutPage(driver);
        }
    }
}
