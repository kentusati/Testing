using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Pages
{
    public class MainPageEu
    {
        private IWebDriver _driver;
        public IWebElement _regionMenu => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[3]/div[2]/div/div/strong/a"));
        public IWebElement _regionSwap => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[3]/div[2]/div/ul/li[2]/a"));
        public IWebElement _close1 => _driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div/div/div/button"));
        public IWebElement _close2 => _driver.FindElement(By.XPath("/html/body/div[7]/aside[2]/div[2]/header/button"));

        public MainPageEu(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void SwapRegionBack()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Thread.Sleep(30000);
            _close1.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _close2.Click();
            _regionMenu.Click();
            _regionSwap.Click();
            Thread.Sleep(5000);
        }
    }
}
