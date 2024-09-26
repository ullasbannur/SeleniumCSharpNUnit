using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace TestWithNUnit.Selenium
{
    internal class BrowserCommand
    {
        ChromeDriver driver;

        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            //IWebElement checkbox2 = driver.FindElement(By.XPath("(//input[@type='checkbox'])[1]"));
            //IWebElement checkbox1 = driver.FindElement(By.XPath("(//input[@type='checkbox'])[2]"));
            //checkbox1.Click();
            //checkbox2.Click();

            //IReadOnlyList<IWebElement> Checkboxs = driver.FindElements(By.XPath("//input[@type = 'radio']"));

            //foreach (IWebElement e in Checkboxs)
            //{

            //    Console.WriteLine(e.Text);

            //    e.Click();
            //}

            IWebElement dropdown = driver.FindElement(By.XPath("(//select[@id='dropdown-class-example'])"));
            Assert.IsNotNull(dropdown);
            var select = new SelectElement(dropdown);
            Thread.Sleep(2000);
            select.SelectByIndex(2);
            //select.SelectByValue(option2);



        }

        [TearDown]
        public void tearDownbrowser()
        {
          Thread.Sleep(2000);
          driver.Close();//close current and all session
          //driver.Quit();
        }

    }
}
