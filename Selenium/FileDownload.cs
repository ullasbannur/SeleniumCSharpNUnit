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
    internal class FileDownload
    {
        ChromeDriver driver;

        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {

            IWebElement file = driver.FindElement(By.XPath("//a[normalize-space()='cypress_architecture.jpg']"));
            file.Click();

            string text = file.Text;
            string path = "C:\\Users\\ulban\\Downloads\\" + text;
            Console.WriteLine(path);
            Assert.That(File.Exists(path));


        }


        [TearDown]
        public void stopbrowser()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
