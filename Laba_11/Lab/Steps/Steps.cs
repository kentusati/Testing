using Lab.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Steps
{
    public class Steps
    {
        IWebDriver _driver;
        #region Init&Close
        public void InitBrowser()
        {
            _driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }
        #endregion

        #region Test1
        public void ShowTableSize()
        {
            var mainPage = new MainPage(_driver);
            mainPage.OpenPage();
            mainPage.ClickTableSize();
        }
        #endregion
        #region Test2
        public void SearchWithSort()
        {
            var mainPage = new MainPage(_driver);
            mainPage.OpenPage();
            mainPage.SearchFeid();
        }
        #endregion
        #region Test3
        public void SwapRegion()
        {
            var mainPage = new MainPage(_driver);
            mainPage.OpenPage();
            mainPage.SwapRegion();
        }
        public void SwapRegionBack()
        {
            var mainPageEu = new MainPageEu(_driver);
            mainPageEu.SwapRegionBack();
        }
        #endregion
        #region Test4
        public void OpenHodie()
        {
            var mainPage = new MainPage(_driver);
            mainPage.OpenPage();
            mainPage.ShowHodies();
        }
        public void SelectHodie()
        {
            var hodiePage = new Products(_driver);
            hodiePage.SelectHodie();
        }
        #endregion
        
        #region Test5
        public void OpenAcc()
        {
            var mainPage = new MainPage(_driver);
            mainPage.OpenPage();
            mainPage.OpenAcc();
        }
        public void LogIn()
        {
            var signIn = new SignIn(_driver);
            signIn.LogIn();
        }
        public void ChangeInfo()
        {
            var account = new Account(_driver);
            account.ChangeInfo();
        }
        #endregion

        #region Test6
        public void SupMessSend()
        {
            var mainPage = new MainPage(_driver);
            mainPage.OpenPage();
            mainPage.SendMessage();
        }
        #endregion

        #region Test7
        public void ShowPolo()
        {
            var mainPage = new MainPage(_driver);
            mainPage.OpenPage();
            mainPage.ShowPolo();
        }
        public void SetInterval()
        {
            var productsPage = new Products(_driver);
            productsPage.SelectInterval();
        }
        #endregion

        #region Test8
        public void DeleteProduct()
        {
            var mainPage = new MainPage(_driver);
            mainPage.DeleteProduct();
        }
        #endregion
        #region Test9
        public void UpdateProduct()
        {
            var mainPage = new MainPage(_driver);
            mainPage.UpdateProduct();
        }
        #endregion
        public void ShowBags()
        {
            var mainPage = new MainPage(_driver);
            mainPage.OpenPage();
            mainPage.ShowBags();
        }
        public void UseFilter()
        {
            var productPage = new Products(_driver);
            productPage.UseFilter();
        }
    }
}
