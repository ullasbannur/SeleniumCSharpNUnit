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
    internal class KeyboardActions
    {
        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/single_text_input.html");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {


            new Actions(driver).KeyUp(Keys.Shift).SendKeys("a").Perform();

            Thread.Sleep(2000);

        }


        [TearDown]
        public void TearDown()
        {

            driver.Close();

        }
    }
}
