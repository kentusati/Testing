using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Pages
{
    public class SignIn
    {
        string email = "";
        string password = "";
        private IWebDriver _driver;
        private IWebElement _email => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div/div/div[5]/div[1]/div[3]/form/fieldset/div[3]/div/input"));
        private IWebElement _password => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div/div/div[5]/div[1]/div[3]/form/fieldset/div[4]/div/input"));
        private IWebElement _signInButton => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div/div/div[5]/div[1]/div[3]/form/fieldset/div[5]/div[2]/button"));
        
        public SignIn(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void LogIn()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _email.Click();
            _email.SendKeys(email);
            _password.Click();
            _password.SendKeys(password);
            _signInButton.Click();
        }
    }
}
