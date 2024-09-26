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
    internal class DragDrop
    {
        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {

            IWebElement source = driver.FindElement(By.XPath("//div[@id='column-a']"));
            IWebElement destination = driver.FindElement(By.XPath(" //div[@id='column-b']"));

            new Actions(driver).DragAndDrop(source,destination).Perform();

            Thread.Sleep(5000);

        }


        [TearDown]
        public void TearDown()
        {

            driver.Close();

        }


    }
}
