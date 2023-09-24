using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace YoungLivingAutomation.Pages
{
    /// <summary>
	/// Represent Checkout page 
	/// </summary>
    public class CheckoutPage : BasePage
    {
        private IWebDriver driver;

        public CheckoutPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[data-testid='qa-referral-code-continue']")]
        public IWebElement referralContinueButton;

        [FindsBy(How = How.CssSelector, Using = "[data-testid='qa-confirm-yes']")]
        public IWebElement continueWithoutSponsorButton;

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement firstNameTextBox;

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement lastNameTextBox;

        [FindsBy(How = How.Id, Using = "addressLine1")]
        public IWebElement addressLine1TextBox;

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement cityTextBox;

        [FindsBy(How = How.Id, Using = "stateList")]
        public IWebElement stateListTextBox;

        [FindsBy(How = How.CssSelector, Using = "option[value='AL'][data-testid='qa-options']")]
        public IWebElement stateSelectionAL;

        [FindsBy(How = How.Id, Using = "zip")]
        public IWebElement zipTextBox;

        [FindsBy(How = How.CssSelector, Using = "[data-testid='qa-ship-continue']")]
        public IWebElement continueShipButton;

        [FindsBy(How = How.CssSelector, Using = "[data-testid='qa-ship-methods-continue']")]
        public IWebElement continueShipmethodButton;

        [FindsBy(How = How.CssSelector, Using = "[data-testid='qa-suggestion-save']")]
        public IWebElement saveChangesButton;

        [FindsBy(How = How.Id, Using = "payment-dd")]
        public IWebElement paymentMethodTypeSelector;

        [FindsBy(How = How.Id, Using = "cards-ACH")]
        public IWebElement bankAccountOption;

        [FindsBy(How = How.Id, Using = "bankName")]
        public IWebElement bankNameTextBox;

        [FindsBy(How = How.Id, Using = "cardFirstName")]
        public IWebElement cardFirstNameTextBox;

        [FindsBy(How = How.Id, Using = "cardLastName")]
        public IWebElement cardLastNameTextBox;

        [FindsBy(How = How.Id, Using = "routingNumber")]
        public IWebElement routingNumberTextBox;

        [FindsBy(How = How.Id, Using = "accountNumber")]
        public IWebElement accountNumberTextBox;

        [FindsBy(How = How.Id, Using = "confirmAccountNumber")]
        public IWebElement confirmAccountNumberTextBox;

        [FindsBy(How = How.CssSelector, Using = "[data-testid='qa-pay-continue']")]
        public IWebElement continuePaymentButton;

        [FindsBy(How = How.CssSelector, Using = "label[for='registerAgreementCheckbox']")]
        public IWebElement termsConditionsCheckBox;

        /// <summary>
        /// Waiter for Checkout page
        /// </summary>
        public CheckoutPage waitForCheckoutPageToLoad()
        {
            WaitForElementToLoad(By.Id("sponsorSearch"));
            return this;
        }

        /// <summary>
        /// Waiter for Sponsor section
        /// </summary>
        public CheckoutPage waitForSponsorWindowToLoad()
        {
            WaitForElementToLoad(By.CssSelector("[data-testid='qa-confirm-yes']"));
            return this;
        }

        /// <summary>
        /// Method to click Continue button on Refferal section
        /// </summary>
        public CheckoutPage clickReferralContinueButton()
        {
            referralContinueButton.Click();
            return this;
        }

        /// <summary>
        /// Method to click Continue button Sposor pop up
        /// </summary>
        public CheckoutPage clickContinueWithoutSponsorButton()
        {
            continueWithoutSponsorButton.Click();
            return this;
        }

        /// <summary>
        /// Waiter for Shipping Adress section
        /// </summary>
        public CheckoutPage waitForShippingAdress()
        {
            WaitForElementToLoad(By.Id("firstName"));
            return this;
        }

        /// <summary>
		/// Enter user First Name to textbox
		/// </summary>
		/// <param name="firstName">User First Name.</param>
        public CheckoutPage setFirstName(String firstName)
        {
            firstNameTextBox.SendKeys(firstName);
            return this;
        }

        /// <summary>
		/// Enter user Last Name to textbox
		/// </summary>
		/// <param name="lastName">User Last Name.</param>
        public CheckoutPage setLastName(String lastName)
        {
            lastNameTextBox.SendKeys(lastName);
            return this;
        }

        /// <summary>
		/// Enter shipping address to textbox
		/// </summary>
		/// <param name="address">Address line 1.</param>
        public CheckoutPage setAddress(String address)
        {
            addressLine1TextBox.SendKeys(address);
            return this;
        }

        /// <summary>
		/// Enter city to textbox
		/// </summary>
		/// <param name="city">City.</param>
        public CheckoutPage setCity(String city)
        {
            cityTextBox.SendKeys(city);
            return this;
        }

        /// <summary>
		/// Select state
		/// </summary>
        public CheckoutPage setState()
        {
            stateListTextBox.Click();
            stateSelectionAL.Click();
            return this;
        }

        /// <summary>
		/// Enter Zip Code to textbox
		/// </summary>
		/// <param name="zipCode">Zip Code.</param>
        public CheckoutPage setZipCode(String zipCode)
        {
            zipTextBox.SendKeys(zipCode);
            return this;
        }

        /// <summary>
        /// Method to click Continue button on Shipping Address
        /// </summary>
        public CheckoutPage clickContinueAfterAddress()
        {
            continueShipButton.Click();
            return this;
        }

        /// <summary>
		/// Waiter for Adrress section pop up
		/// </summary>
        public CheckoutPage waitForAddressPopUp()
        {
            WaitForElementToLoad(By.Id("suggestion-modal-header"));
            return this;
        }

        /// <summary>
		/// Waiter for Shipping method section
		/// </summary>
        public CheckoutPage waitForShipMethod()
        {
            WaitForElementToLoad(By.CssSelector("[data-testid='qa-ship-method-selected']"));
            return this;
        }

        /// <summary>
		/// Click Save Changes button on verify address pop up
		/// </summary>
        public CheckoutPage clickSaveChangesOnVerifyAdressPopUp()
        {
            saveChangesButton.Click();
            return this;
        }

        /// <summary>
        /// Method to click Continue button Shipping Method section
        /// </summary>
        public CheckoutPage clickShipMethodContinue()
        {
            continueShipmethodButton.Click();
            return this;
        }

        /// <summary>
        /// Waiter for Payment method section
        /// </summary>
        public CheckoutPage waitForPaymentMethod()
        {
            WaitForElementToLoad(By.CssSelector("[data-testid='qa-pay-continue']"));
            return this;
        }

        /// <summary>
        /// Select Payment method type to Bank Account
        /// </summary>
        public CheckoutPage setPaymentMethodType()
        {
            waitForPaymentMethod();
            paymentMethodTypeSelector.Click();
            bankAccountOption.Click();
            return this;
        }

        /// <summary>
        /// Enter Bank Name to textbox
        /// </summary>
        public CheckoutPage setBankName()
        {
            bankNameTextBox.SendKeys("Bank Of Amerika");
            return this;
        }

        /// <summary>
		/// Enter user First Name to textbox
		/// </summary>
		/// <param name="cardFirstName">Account owner First Name.</param>
        public CheckoutPage setCardFirstName(String cardFirstName)
        {
            cardFirstNameTextBox.SendKeys(cardFirstName);
            return this;
        }

        /// <summary>
		/// Enter user Last Name to textbox
		/// </summary>
		/// <param name="cardLastName">Account owner Last Name.</param>
        public CheckoutPage setCardLastName(String cardLastName)
        {
            cardLastNameTextBox.SendKeys(cardLastName);
            return this;
        }

        /// <summary>
		/// Enter user Routing Number
		/// </summary>
		/// <param name="username">Routing Number.</param>
        public CheckoutPage setRoutingNumber(String routingNumber)
        {
            routingNumberTextBox.SendKeys(routingNumber);
            return this;
        }

        /// <summary>
		/// Enter user accountNumber
		/// </summary>
		/// <param name="accountNumber">Account number.</param>
        public CheckoutPage setAccountNumber(String accountNumber)
        {
            accountNumberTextBox.SendKeys(accountNumber);
            return this;
        }

        /// <summary>
		/// Enter re-user accountNumber
		/// </summary>
		/// <param name="accountReEnterNumber">Account number same as "accountNumber".</param>
        public CheckoutPage setReEnterAccountNumber(String accountReEnterNumber)
        {
            confirmAccountNumberTextBox.SendKeys(accountReEnterNumber);
            return this;
        }

        /// <summary>
        /// Waiter for Payment section button
        /// </summary>
        public CheckoutPage waitForContinueAfterPaymentButton()
        {
            WaitForElementToLoad(By.CssSelector("[data-testid='qa-pay-continue']"));
            return this;
        }

        /// <summary>
        /// Method to click Continue button After Pamyment details section
        /// </summary>
        public CheckoutPage clickContinueAfterPayment()
        {
            waitForContinueAfterPaymentButton();
            continuePaymentButton.Click();
            return this;
        }

        /// <summary>
        /// Waiter for checkbox with Terms And Cond
        /// </summary>
        public CheckoutPage waitForCheckBoxWithTermsAndCond()
        {
            WaitForElementToLoad(By.CssSelector("[data-testid='qa-checkout-become-terms-link']"));
            return this;
        }

        /// <summary>
        /// Method to check checkbox with Terms And Cond
        /// </summary>
        public CheckoutPage checkCheckBoxWithTermsAndCond()
        {
            termsConditionsCheckBox.Click();
            return this;
        }

        /// <summary>
        /// Method to skip Refferal section
        /// </summary>
        public CheckoutPage clickContinueWithoutRefferal()
        {
            waitForCheckoutPageToLoad();
            clickReferralContinueButton();
            waitForSponsorWindowToLoad();
            clickContinueWithoutSponsorButton();
            return this;
        }

        /// <summary>
        /// Fill Shipping Address with personal and address data
        /// </summary>
        public CheckoutPage fillShippingAddress()
        {
            waitForShippingAdress();
            setFirstName("Jack");
            setLastName("Jones");
            setAddress("1234 Elm Street Birmingham, AL 35203");
            setCity("Birmingham");
            setZipCode("35203");
            setState();
            clickContinueAfterAddress();
            waitForAddressPopUp();
            clickSaveChangesOnVerifyAdressPopUp();
            clickContinueAfterAddress();
            Thread.Sleep(4000);
            waitForShipMethod();
            clickShipMethodContinue();
            return this;
        }

        /// <summary>
        /// Fill payment data with Bank Account details
        /// </summary>
        public CheckoutPage fillPaymentMethod()
        {
            setPaymentMethodType();
            setBankName();
            setCardFirstName("Jack");
            setCardLastName("Jones");
            setRoutingNumber("021000021");
            setAccountNumber("1234567890");
            setReEnterAccountNumber("1234567890");
            clickContinueAfterPayment();
            return this;
        }
    }
}
