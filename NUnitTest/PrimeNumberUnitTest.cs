using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithNUnit.NUnitTest
{
    internal class PrimeNumberUnitTest
    {
        PrimeNumber prime;

        [SetUp]
        public void setup()
        {
            prime = new PrimeNumber();
        }

        [Test]
        public void test1()
        {
            Assert.IsTrue(prime.IsPrime(2));
        }
    }
}
