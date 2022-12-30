using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Lab.Pages
{
    public class MainPage
    {
        private readonly IWebDriver _driver;

        #region Locators for test 1
        private By _sizeTable = By.XPath("/html/body/div[3]/footer/div/div[1]/div[3]/div/div/div/div/div[2]/div[2]/ul/li[3]/a");
        #endregion

        #region Locators for test 2
        private By _searchBar = By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[3]/div[2]/form/div[1]/div/input");
        private By _search = By.XPath("/html/body/div[3]/header/div[3]/div[1]/div[3]/div[2]/form/div[2]/button");
        public By _sortButton = By.CssSelector("#maincontent > div.columns > div.column.main > div.search.results > div.toolbar.toolbar-products > div.toolbar-sorter.sorter.sort-by.text-right > ul > li:nth-child(3) > a");
        #endregion

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }
        #region Test1
        public MainPage ClickTableSize()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _driver.FindElement(_sizeTable).Click();
            Thread.Sleep(5000);
            return new MainPage(_driver);
        }
        #endregion

        #region Test2
        public MainPage SearchFeid()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _driver.FindElement(_searchBar).Click();
            _driver.FindElement(_searchBar).SendKeys("Штаны");
            _driver.FindElement(_search).Click();
            _driver.FindElement(_sortButton).Click();
            return new MainPage(_driver);
        }
        #endregion
    }
}
