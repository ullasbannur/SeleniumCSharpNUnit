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
    internal class WebTable
    {

        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/   ");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            IWebElement table = driver.FindElement(By.XPath("//table[@id='product' and @name='courses']"));
            IList<IWebElement> data = new List<IWebElement>(table.FindElements(By.XPath("//table[@id=\"product\" and @name=\"courses\"]/tbody/tr[8]/td[2]")));

            Console.WriteLine(data[0].Text);
            


        }


        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            driver.Close();

        }
    }
}
