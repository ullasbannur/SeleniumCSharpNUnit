using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace TestWithNUnit.Selenium
{
    internal class TakeSS
    {
        ChromeDriver driver;

        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {
            Screenshot ss= driver.TakeScreenshot();

            ss.SaveAsFile("C:\\Users\\ulban\\Desktop\\dummy.jpeg");




        }


        [TearDown]
        public void stopbrowser()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
