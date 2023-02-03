using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Data_test
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }


        [TestClass]
        public class UnitTest
        {

            [DynamicData(nameof(ReadExcel), DynamicDataSourceType.Method)]
            [TestMethod]

            public void DataTesting(string name)
            {
                IWebDriver webDriver = new ChromeDriver();
                webDriver.Manage().Window.Maximize();
                webDriver.Url = "https://www.udemy.com/?deal_code=&utm_term=Homepage&utm_content=Textlink&utm_campaign=Rakuten-default&ranMID=39197&ranEAID=%2F68Yt01SgtI&ranSiteID=_68Yt01SgtI-_lQDkxguh3Ck8ukBDqWF4g&utm_source=aff-campaign&LSNPUBID=%2F68Yt01SgtI&utm_medium=udemyads";

                webDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div[2]/form/input[2]")).SendKeys(name);
                webDriver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[3]/div[2]/form/button")).Click();

                webDriver.Quit();





            }
        }
    




}
