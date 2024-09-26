using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using TestWithNUnit.Utilities;

namespace TestWithNUnit.Selenium
{
    internal class Links: BaseClass
    {   

        [Test]
        public void test()
        {
            IReadOnlyList<IWebElement> links = driver.FindElements(By.TagName("a"));

            foreach (IWebElement item in links)
            {
                Console.WriteLine(item.Text + "The URL is" + item.GetAttribute("href"));
            }

        }
    }
}
