using OpenQA.Selenium;
using Lab.Pages;
using OpenQA.Selenium.Chrome;

namespace Lab
{
    public class Tests
    {
        private IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://asia.venum.com/ru/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }

        [Test]
        public void Test1()
        {
            var mainPage = new MainPage(_driver);
            mainPage.ClickTableSize();
        }
        
        [Test]
        public void Test2()
        {
            var mainPage = new MainPage(_driver);
            mainPage.SearchFeid();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}