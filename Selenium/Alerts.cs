using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace TestWithNUnit.Selenium
{
    internal class Alerts
    {
        ChromeDriver driver;

        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            IWebElement SimpleAlert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Alert')]"));
            //"//button[contains(text(),'Click for JS Prompt')]"


            SimpleAlert.Click();

            //IAlert alt = driver.SwitchTo().Alert();
            //alt.Accept();
        }


        [TearDown]
        public void stopbrowser() {
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
