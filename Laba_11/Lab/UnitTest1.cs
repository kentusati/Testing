using Lab.Pages;
using Lab.Steps;

namespace Lab
{
    public class Tests
    {
        private Steps.Steps steps = new Steps.Steps();

        #region Setup&TearDown
        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }
        #endregion

        [Test]
        public void Test1()
        {
            steps.ShowTableSize();
        }
        [Test]
        public void Test2()
        {
            steps.SearchWithSort();
        }
        [Test]
        public void Test3()
        {
            steps.SwapRegion();
            //steps.SwapRegionBack();
        }
        [Test]
        public void Test4()
        {
            steps.OpenHodie();
            steps.SelectHodie();
        }
        [Test]
        public void Test5()
        {
            steps.OpenAcc();
            steps.LogIn();
            steps.ChangeInfo();
        }
        [Test]
        public void Test6()
        {
            steps.SupMessSend();
        }
        [Test]
        public void Test7()
        {
            steps.ShowPolo();
            steps.SetInterval();
        }
        [Test]
        public void Test8()
        {
            steps.OpenHodie();
            steps.SelectHodie();
            steps.DeleteProduct();
        }
        [Test]
        public void Test9()
        {
            steps.OpenHodie();
            steps.SelectHodie();
            steps.UpdateProduct();
        }
        [Test]
        public void Test10()
        {
            steps.ShowBags();
            steps.UseFilter();
        }
    }
}