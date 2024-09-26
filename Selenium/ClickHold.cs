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
    internal class ClickHold
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

            IWebElement Primes = driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));

            IWebElement LatestMovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));

            new Actions(driver)

              .MoveToElement(Primes)
              .MoveToElement(LatestMovies)
              .Click();
            Thread.Sleep(5000);

            //Assert.AreEqual("Prime", driver.FindElement(By.XPath("//span[normalize-space()='Prime']")).Text);



        }


        [TearDown]
        public void TearDown()
        {

            driver.Close();

        }
    }
}
