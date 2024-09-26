using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace TestWithNUnit.Selenium
{
    internal class VerticalScrolling
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
            //scroll down

            IJavaScriptExecutor js=(IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)", " ");

            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)", " ");

            js.ExecuteScript("window.scrollBy(0,4000)", "");

            js.ExecuteScript("window.scrollBy(0,-document.body.scrollHeight)", " ");

            Thread.Sleep(1000);

        }


        [TearDown]
        public void stopbrowser()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
