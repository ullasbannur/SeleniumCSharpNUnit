using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace TestWithNUnit.Selenium
{
    internal class Lab3
    {

        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            //IWebElement UsernameInput = driver.FindElement(By.XPath("//input[@id='email']"));

            new Actions(driver).KeyDown(Keys.Shift).SendKeys("abc2gmail").KeyUp(Keys.Shift).SendKeys(".").KeyDown(Keys.Shift).SendKeys("com").KeyUp(Keys.Shift).KeyDown(Keys.Tab).SendKeys("abcd").KeyDown(Keys.Tab).Click().Perform();

        }


        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            driver.Close();

        }
    }
}
