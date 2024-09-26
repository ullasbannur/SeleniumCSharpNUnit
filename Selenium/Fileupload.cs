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
    internal class Fileupload
    {

        ChromeDriver driver;

        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test()
        {

            IWebElement ChooseFile = driver.FindElement(By.XPath("//input[@id ='file-upload']"));
            ChooseFile.SendKeys("C:\\Users\\ulban\\Desktop\\dummy.png");

            IWebElement Upload = driver.FindElement(By.XPath("//input[@id = 'file-submit']"));
            Upload.Click();

            Thread.Sleep(1000);

            IWebElement FileUploadMsg = driver.FindElement(By.XPath("//h3[contains(text(),'File Uploaded!')]"));

            string textmsg = FileUploadMsg.Text;

            string expectedtext = "File Uploaded!";

            Console.WriteLine(textmsg);

            Assert.AreEqual(textmsg, expectedtext);


        }


        [TearDown]
        public void stopbrowser()
        {
            Thread.Sleep(5000);
            driver.Close();
        }
    }

}
