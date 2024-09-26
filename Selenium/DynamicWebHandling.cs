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
    internal class DynamicWebHandling
    {

        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/tables");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            IWebElement element = driver.FindElement(By.XPath("//li[@class='Footer_column__link__yFR1_']//a[normalize-space()='Our Culture']"));

            

            string text = element.Text;

            Console.WriteLine(text);

            

        }


        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            driver.Close();

        }
    }

}
