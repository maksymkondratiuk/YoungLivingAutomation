using NUnit.Framework;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoungLivingAutomation.Pages;

namespace YoungLivingAutomation.Tests
{
    /// <summary>
    /// Test for Order Checkout functionality
    /// </summary>
    [TestFixture]
    public class OrderCheckoutTest : BaseTest
    {

        /// <summary>
        /// Validate that an order can be checkout
        /// </summary>
        [Test]
        public void ValidateThatOrderCanBeCheckout()
        {
            BasePage page = new BasePage(driver);
            page.homePage()
                .clickSigninLink()
                .loginWithCredentials("cel98@ukr.net", "PasswordQA1")
                .waitForMainPageToLoad()
                .searchForProduct("essential oil")
                .waitForProductsScreenToLoad()
                .clickAddToCart()
                .waitForShoppingCartToLoad()
                .clickViewCartButton()
                .waitForViewCartToLoad()
                .clickCheckoutButton()
                .clickContinueWithoutRefferal()
                .fillShippingAddress()
                .fillPaymentMethod()
                .waitForCheckBoxWithTermsAndCond()
                .checkCheckBoxWithTermsAndCond();
        }
    }
}
