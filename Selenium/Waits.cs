using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace TestWithNUnit.Selenium
{
    internal class Waits
    {

        public ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/   ");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            // chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //wait.Until(d => login.Displayed);
            //WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(2))
            //{
            //  PollingInterval = TimeSpan.FromMilliseconds(300),
            //};
            //wait1.IgnoreExceptionTypes(typeof(ElementNotInteractableException));

            //wait.Until(d => {
            //    login.SendKeys("Displayed");
            //    return true;
            //}
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            driver.Close();

        }
    }
}
