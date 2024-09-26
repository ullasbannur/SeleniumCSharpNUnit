using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestWithNUnit.Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestWithNUnit.DataDrivenTesting
{
    internal class TestParUsingTestcase: BaseClass
    {
        [Test]
        [TestCase("Admin","admin")]
       

        public void LoginTest(string username, string password)
        {

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);
            IWebElement Ussername = driver.FindElement(By.Name("user-name"));
            Ussername.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.Name("login-button"));
            LoginButton.Click();

            Thread.Sleep(1000);

            IWebElement  errormsg = driver.FindElement(By.XPath("//h3[@data-test='error']"));

            string errormsgs= errormsg.Text;
            Console.WriteLine(errormsgs);

            Assert.AreEqual("Epic sadface: Username and password do not match any user in this service",errormsgs);
        }
    }
}
