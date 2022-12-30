using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Pages
{
    public class Account
    {
        private IWebDriver _driver;

        private IWebElement _editInfo => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div[2]/div[3]/div[2]/div[1]/div[2]/a[1]"));
        private IWebElement _firstName => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div[2]/form/fieldset[1]/div[1]/div/fieldset/div/div[1]/div/input"));
        private IWebElement _saveButton => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div[2]/form/div/div[1]/button"));

        
        public Account(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void ChangeInfo()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _editInfo.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _firstName.SendKeys("Maksim");
            _saveButton.Click();
        }
    }
}
