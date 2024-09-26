using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithNUnit.NUnitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class Class2
    {
        [Test, Order(2)]
        public void addCart()
        {
            Console.WriteLine("selecting the cart");
        }
        [Test, Order(1)]
        public void products()
        {
            Console.WriteLine("selecting the product");
        }
        [Test, Order(3)]
        public void login()
        {
            Console.WriteLine("selecting the login");
        }
    }
}
