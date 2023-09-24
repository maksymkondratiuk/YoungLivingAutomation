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
	/// Represent Login page 
	/// </summary>
	public class LoginPage : BasePage
	{
		private IWebDriver driver;

		[FindsBy(How = How.Id, Using = "loginUsername")]
		public IWebElement usernameTextfield;

		[FindsBy(How = How.Id, Using = "continue-btn")]
		public IWebElement continueButton;

		[FindsBy(How = How.Id, Using = "loginPassword")]
		public IWebElement passwordTextfield;

		[FindsBy(How = How.Id, Using = "login-btn")]
		public IWebElement logInButton;


		public LoginPage(IWebDriver driver) : base(driver)
		{
			this.driver = driver;
			PageFactory.InitElements(driver, this);
		}

		/// <summary>
		/// Enter user username to textbox
		/// </summary>
		/// <param name="username">User password.</param>
		public LoginPage setUsername(String username)
		{
			usernameTextfield.SendKeys(username);
			return this;
		}

		/// <summary>
		/// Enter user password to textbox
		/// </summary>
		/// <param name="password">User password.</param>
		public LoginPage setPassword(String password)
		{
			passwordTextfield.SendKeys(password);
			return this;
		}

		/// <summary>
		/// Click Continue button method
		/// </summary>
		public LoginPage clickContinue()
		{
			continueButton.Click();
			return this;
		}

		/// <summary>
		/// Click Login button method
		/// </summary>
		public MainPage clickLogin()
		{
			logInButton.Click();
			return new MainPage(driver);
		}

		/// <summary>
		/// Waiter for enter password screen
		/// </summary>
		public LoginPage waitForPasswordScreenToLoad()
		{
			WaitForElementToLoad(By.Id("loginPassword"));
			return this;
		}

		/// <summary>
		/// Login with username and password
		/// </summary>
		/// <param name="username">User email.</param>
		/// <param name="password">User password.</param>
		public MainPage loginWithCredentials(String username, String password)
		{
			setUsername(username);
			clickContinue();
			waitForPasswordScreenToLoad();
			setPassword(password);
			clickLogin();
			return new MainPage(driver);
		}
	}
}
