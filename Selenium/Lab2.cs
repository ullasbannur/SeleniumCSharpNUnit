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
    internal class Lab2
    {

        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            string parenthandle = driver.CurrentWindowHandle;
            Assert.IsNotNull(parenthandle);

            IWebElement clik = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            clik.Click();

            Thread.Sleep(1000);

            IList<string> handles=driver.WindowHandles;

            driver.SwitchTo().Window(handles[1]);

            string titlechild = driver.Title;

            Assert.That(titlechild, Is.EqualTo("New Window"));


            driver.Close();

            Thread.Sleep(1000);


            driver.SwitchTo().Window(parenthandle);



            Thread.Sleep(1000);


        }


        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(1000);
            driver.Close();

        }
    }
}
