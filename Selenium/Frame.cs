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
    internal class Frame
    {

        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {


            IWebElement iframe = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            driver.SwitchTo().Frame(iframe);


            Thread.Sleep(5000);
            //driver.SwitchTo().Frame(0);
            //driver.SwitchTo().Frame("frameone");


            IWebElement radiobutton = driver.FindElement(By.XPath("//label[normalize-space()='New York']"));

            radiobutton.Click();

            Thread.Sleep(4000);
            //label[@for='radio-


        }


        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(3000);
            driver.Close();

        }
    }
}
