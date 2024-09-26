using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.DevTools.V85.IndexedDB;

namespace TestWithNUnit.Selenium
{
    internal class Lab1
    {

        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            IWebElement frame = driver.FindElement(By.XPath(" //iframe[@id='mce_0_ifr']"));

            driver.SwitchTo().Frame(frame);
            Thread.Sleep(1000);

            IWebElement para = driver.FindElement(By.XPath("//p[normalize-space()='Your content goes here.']"));
            para.Clear();

            Thread.Sleep(1000);

            para.SendKeys("habibi come to EG");
            Thread.Sleep(3000);




        }


        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            driver.Close();

        }
    }
}
