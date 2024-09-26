using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using System.Data;

namespace TestWithNUnit.Selenium
{
    internal class WindowHandling
    {
        ChromeDriver driver;
        [SetUp]

        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/window_switching_tests/page_with_frame.html");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {

            //fetch handle of first page
            string curwinhandle=driver.CurrentWindowHandle;
            Assert.IsNotNull(curwinhandle);

            

            //click on new link option
            IWebElement open = driver.FindElement(By.XPath("//a[@id='a-link-that-opens-a-new-window']"));
            open.Click();

            Thread.Sleep(4000);


            //fethc all
            IList<string> windowHandles = new List<string>(driver.WindowHandles);   
            //control moved to child window
            driver.SwitchTo().Window(windowHandles[1]);

            Thread.Sleep(4000);

            string title = driver.Title;
            Console .WriteLine(title);
            Assert.AreEqual("Simple Page",title);
            driver.Close();

            driver.SwitchTo().Window(windowHandles[0]);
            string text = driver.Title;

            Assert.That(text,Is.EqualTo("Test page for WindowSwitchingTest.testShouldFocusOnTheTopMostFrameAfterSwitchingToAWindow"));



           

        }


        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(2000);
            driver.Close();

        }

    }
}
