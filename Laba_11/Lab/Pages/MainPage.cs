using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Lab.Pages
{
    public class MainPage
    {
        private IWebDriver _driver;
        private string BASE_URL = "https://asia.venum.com/ru/";

        #region Locators for test 1
        private IWebElement _sizeTable => _driver.FindElement(By.XPath("/html/body/div[3]/footer/div/div[1]/div[3]/div/div/div/div/div[2]/div[2]/ul/li[3]/a"));
        #endregion
        #region Locators for test 2
        private IWebElement _searchBar => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[3]/div[2]/form/div[1]/div/input"));
        private IWebElement _search => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[3]/div[2]/form/div[2]/button"));
        private IWebElement _sortButton => _driver.FindElement(By.CssSelector("#maincontent > div.columns > div.column.main > div.search.results > div.toolbar.toolbar-products > div.toolbar-sorter.sorter.sort-by.text-right > ul > li:nth-child(3) > a"));
        #endregion
        #region Locators for test3
        public IWebElement _regionMenu => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[3]/div[2]/div/div/strong/a"));
        public IWebElement _firstRegion => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[3]/div[2]/div/ul/li[1]/a"));
        #endregion
        #region Locators for test 4
        private IWebElement _overMan => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[2]/nav/ul/li[3]/a"));
        private IWebElement _openHodies => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[2]/nav/ul/li[3]/div/ul/div[4]/li/ul/li[1]/a"));
        #endregion
        #region Locators for test 5
        private IWebElement _account => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[3]/div[1]/a"));
        private IWebElement _accountDashboard => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[3]/div[1]/div/ul/li[1]/a"));
        #endregion
        #region Locators for test 6
        private IWebElement _messChat => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div[3]/div[3]/div/div/div[1]/a"));
        private IWebElement _ourName => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div/form/fieldset/div[2]/div/input"));
        private IWebElement _ourEmail => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div/form/fieldset/div[3]/div/input"));
        private IWebElement _description => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div/form/fieldset/div[5]/div/textarea"));
        private IWebElement _sendButtonMess => _driver.FindElement(By.XPath("/html/body/div[3]/div[1]/main/div[2]/div/form/div/div/button"));
        #endregion
        #region Locators for test 7
        private IWebElement _openPolos => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[2]/nav/ul/li[3]/div/ul/div[2]/li/ul/li[2]/a"));
        #endregion
        #region Locators for test 8
        private IWebElement _deleteButton => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[4]/div[2]/div/div/div[2]/div[4]/ol/li/div/div/div[3]/div[2]/a"));
        private IWebElement _deleteSubmitButton => _driver.FindElement(By.CssSelector("body > div.modals-wrapper > aside.modal-popup.confirm._show > div.modal-inner-wrap > footer > button.action-primary.action-accept"));
        #endregion
        
        #region Locators for test 9
        private IWebElement _changeButton => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[4]/div[2]/div/div/div[2]/div[4]/ol/li/div/div/div[3]/div[1]/a"));
        private IWebElement _qtyInput => _driver.FindElement(By.CssSelector("#qty"));
        private IWebElement _updateButton => _driver.FindElement(By.CssSelector("#product-updatecart-button"));
        #endregion
        private IWebElement _openBags => _driver.FindElement(By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[2]/nav/ul/li[3]/div/ul/div[6]/li/ul/li[2]/a"));

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }
        #region Test1
        public void ClickTableSize()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _sizeTable.Click();
            Thread.Sleep(5000);
        }
        #endregion
       
        #region Test2
        public void SearchFeid()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _searchBar.Click();
            _searchBar.SendKeys("Штаны");
            _search.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _sortButton.Click();
            Thread.Sleep(5000);
        }
        #endregion

        #region Test3
        public void SwapRegion()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _regionMenu.Click();
            _firstRegion.Click();
            Thread.Sleep(5000);
        }
        #endregion

        #region Test4
        public void ShowHodies()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Actions action = new Actions(_driver);
            action.MoveToElement(_overMan).MoveToElement(_openHodies).Click().Perform();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Thread.Sleep(5000);
        }
        #endregion

        #region Test5
        public void OpenAcc()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Actions action = new Actions(_driver);
            action.MoveToElement(_account).MoveToElement(_accountDashboard).Click().Perform();
            Thread.Sleep(10000);
        }
        #endregion

        #region Test6
        public void SendMessage()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _messChat.Click();
            _ourName.Click();
            _ourName.SendKeys("Maksim Khvalei Sergeevich");
            _ourEmail.Click();
            _ourEmail.SendKeys("");
            _description.Click();
            _description.SendKeys("this message was sent by an automated test");
            //_sendButtonMess.Click();
            Thread.Sleep(5000);
        }
        #endregion

        #region Test7
        public void ShowPolo()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Actions action = new Actions(_driver);
            action.MoveToElement(_overMan).MoveToElement(_openPolos).Click().Perform();
        }
        #endregion

        #region Test8
        public void DeleteProduct()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _deleteButton.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _deleteSubmitButton.Click();
        }
        #endregion
        
        #region Test9
        public void UpdateProduct()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _changeButton.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _qtyInput.SendKeys("2");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _updateButton.Click();
        }
        #endregion

        #region Test10
        public void ShowBags()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Actions action = new Actions(_driver);
            action.MoveToElement(_overMan).MoveToElement(_openBags).Click().Perform();
        }
        #endregion
    }
}
