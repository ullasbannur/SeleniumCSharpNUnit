using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace TestWithNUnit.Selenium
{

    internal class Login
    {
        ChromeDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new ChromeDriver();
            // launch the chrome browser
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

        }




        [Test]
        public void testcase1()
        {
            Thread.Sleep(5000);
            IWebElement Ussername = driver.FindElement(By.Name("user-name"));
            Ussername.SendKeys("standard_user");

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            IWebElement LoginButton = driver.FindElement(By.Name("login-button"));
            LoginButton.Click();
        }


        [TearDown]
        public void tearDownbrowser()
        {
            Thread.Sleep(5000);
            driver.Close();

        }
    }
}

