using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestWithNUnit.Selenium
{
    internal class CalenderPicker
    {
        private IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestcaseCalendarPicker()
        {
            Thread.Sleep(3000);
            try
            {
                Thread.Sleep(3000);
                IWebElement d = driver.FindElement(By.XPath("(//span[@class='commonModal__close'])[1]"));
                d.Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Thread.Sleep(2000);
            IWebElement datePickerLabel = driver.FindElement(By.XPath("//label[@for='departure']"));
            datePickerLabel.Click();
            Thread.Sleep(3000);
            IWebElement targetDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[3]/div[4]/div[2]/div[1]/p[1]"));
            targetDate.Click();
            Thread.Sleep(6000);


        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}


