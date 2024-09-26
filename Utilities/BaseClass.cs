using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace TestWithNUnit.Utilities
{
    internal class BaseClass
    {
        public IWebDriver driver;
        [SetUp]
        public void Startbrowser()
        {

            string browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            
            //driver.Navigate().GoToUrl("");  
            //driver.Manage().Window.Maximize();  
           
        }
        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }


        [TearDown]
        public void Teardownbrowser()
        {
            Thread.Sleep(1000);
            driver.Close();
        }


    }
}
