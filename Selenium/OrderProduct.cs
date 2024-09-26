using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
//using OpenQA.Selenium.Chrome;

namespace TestWithNUnit.Selenium
{
    internal class OrderProduct
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            Thread.Sleep(2000);
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Testcase1()
        {
            Thread.Sleep(2000);
            IWebElement name = driver.FindElement(By.Id("user-name"));
            name.SendKeys("standard_user");

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");

            IWebElement login = driver.FindElement(By.Id("login-button"));
            login.Click();

            Thread.Sleep(2000);
            IWebElement addToCartButton = driver.FindElement(By.XPath("//button[contains(text(),'Add to cart')]"));
            addToCartButton.Click();

            Thread.Sleep(2000);
            IWebElement shoppingCart = driver.FindElement(By.ClassName("shopping_cart_link"));
            shoppingCart.Click();

            Thread.Sleep(2000);
            IWebElement checkoutButton = driver.FindElement(By.Id("checkout"));
            checkoutButton.Click();

            Thread.Sleep(2000);
            IWebElement firstName = driver.FindElement(By.Id("first-name"));
            firstName.SendKeys("John");

            IWebElement lastName = driver.FindElement(By.Id("last-name"));
            lastName.SendKeys("Cena");

            IWebElement postalCode = driver.FindElement(By.Id("postal-code"));
            postalCode.SendKeys("12345");

            IWebElement continueButton = driver.FindElement(By.Id("continue"));
            continueButton.Click();

            Thread.Sleep(2000);
            IWebElement finishButton = driver.FindElement(By.Id("finish"));
            finishButton.Click();

            Thread.Sleep(2000);
            IWebElement thankYouText = driver.FindElement(By.ClassName("complete-header"));
            string got = thankYouText.Text;
            string expected = "Thank you for your order!";
            Assert.That(got, Is.EqualTo(expected));
        }

        [TearDown]
        public void TearDownBrowser()
        {
            Thread.Sleep(10000);
            driver.Close();
        }
    }
}