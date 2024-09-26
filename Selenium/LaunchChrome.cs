using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace TestWithNUnit.Selenium
{
    internal class LaunchChrome
    {
        [SetUp]
        public void Startbrowser() {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());   //config webdriver manager to setup chorme capabilitiess

            // ChromeDriver driver = new ChromeDriver();  // initialise the chrome web browser

            //driver.Navigate().GoToUrl("https://www.selenium.dev/downloads/");  //navigate to chrome link

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            EdgeDriver driver = new EdgeDriver();

            driver.Navigate().GoToUrl("https://www.selenium.dev/downloads/");


        }


        [Test]
        public void Testcase1() { }


        [TearDown]
        public void Teardownbrowser() { }



    }


}
