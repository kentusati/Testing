using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace MyTest
{
    public class Tests
    {
        [Test]
        public void SizeTableClick()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://asia.venum.com/ru/";
            Thread.Sleep(160000);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/html/body/div[3]/footer/div/div[1]/div[3]/div/div/div/div/div[2]/div[2]/ul/li[3]/a")).Click();
            driver.Close();
        }
    }
}