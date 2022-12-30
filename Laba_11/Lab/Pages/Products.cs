using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Pages
{
    public class Products
    {
        private IWebDriver _driver;
        #region Locators for hodies
        private IWebElement _hodie => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div[1]/div[7]/ol/li[32]/div"));
        private IWebElement _size => _driver.FindElement(By.CssSelector("#product-options-wrapper > div > div > div > div > div:nth-child(4)"));
        private IWebElement _addingButton => _driver.FindElement(By.CssSelector("#product-addtocart-button"));
        #endregion
        private IWebElement _leftControl => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div[2]/div/div[2]/div/div/div[2]/div/div[3]/a[1]"));
        private IWebElement _rightControl => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div[2]/div/div[2]/div/div/div[2]/div/div[3]/a[2]"));
        private IWebElement _okButton => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div[2]/div/div[2]/div/div/div[2]/div/div[3]/a[2]"));
        private IWebElement _checkBox => _driver.FindElement(By.CssSelector("#narrow-by-list > div:nth-child(2) > div.filter-options-content > div > ol > li:nth-child(1) > a"));

        public Products(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void SelectHodie()
        {
            _hodie.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _size.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _addingButton.Click();
        }
        public void SelectInterval()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            for (int i = 0; i < 51; i++)
            {
                _leftControl.SendKeys(Keys.ArrowRight);
            }
            for (int i = 0; i < 51; i++)
            {
                _rightControl.SendKeys(Keys.ArrowLeft);
            }
            _okButton.Click();
            Thread.Sleep(10000);
        }
        public void UseFilter()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Actions action = new Actions(_driver);
            action.MoveToElement(_checkBox).Click().Perform();
            Thread.Sleep(15000);
        }
    }
}
