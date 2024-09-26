using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithNUnit.DataDrivenTesting
{
    internal class TestParUsingTestCaseSource
    {

        [Test,TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username+" :"+ password);

        }
        public static IEnumerable<TestCaseData> GetTestData()
        {

            yield return new TestCaseData("abc.com", "ghhjj");
            yield return new TestCaseData("ghh.com", "fghhj");
            yield return new TestCaseData("mkk.com", "ddffg");
        }
    }
}
