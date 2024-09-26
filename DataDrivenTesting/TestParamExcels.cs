using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestWithNUnit.Utilities;
using OpenQA.Selenium.Chrome;

namespace TestWithNUnit.DataDrivenTesting
{
    internal class TestParamExcels : BaseClass
    {   

        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

            Thread.Sleep(1000);
            IWebElement Ussername = driver.FindElement(By.Name("user-name"));
            Ussername.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.Name("login-button"));
            LoginButton.Click();   

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {

            var cols = new List<string> { "username", "password" };

           return ExcelRead.GetTestDataFromExcel("C:\\Users\\ulban\\source\\repos\\TestWithNUnit\\TestData.xlsx", "Sheet1", cols);

                
        }
    }
}