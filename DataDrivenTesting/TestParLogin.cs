using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestWithNUnit.Utilities;

namespace TestWithNUnit.DataDrivenTesting
{
    internal class TestParLogin : BaseClass
    {
        [TestCase("Admin", "admin123")]
        //[TestCase("cds@gmail.com", "1232")]
        //[TestCase("sss@gmail.com", "1232")]
        public void LoginTest(string username, string password)
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();

            Console.WriteLine(username + " " + password);
            Thread.Sleep(2000);
            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement Submit = driver.FindElement(By.XPath("//button[@type='submit']"));
            Submit.Click();
            Thread.Sleep(2000);

        }
    }
}
