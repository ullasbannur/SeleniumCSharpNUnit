using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestWithNUnit.Selenium
{
    internal class ContextClick
    {
        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.in/ref=nav_logo");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {

            IWebElement deal = driver.FindElement(By.XPath(" //a[contains(@href,'/deals?ref_=nav_cs_gb')] "));

            //Action action = new Action();

            new Actions(driver).ContextClick(deal).Perform();

            Thread.Sleep(2000);




        }


        [TearDown]
        public void TearDown()
        {

            driver.Close();

        }
    }
}
