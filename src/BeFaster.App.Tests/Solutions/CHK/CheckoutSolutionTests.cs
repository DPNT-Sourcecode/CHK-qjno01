using BeFaster.App.Solutions.CHK;
using BeFaster.App.Solutions.SUM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Tests.Solutions.CHK
{
    [TestFixture]
    public class CheckoutSolutionTests
    {
        [TestCase("A", ExpectedResult = 50)]
        public int CheckoutTestA(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("B", ExpectedResult = 30)]
        public int CheckoutTestB(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("C", ExpectedResult = 20)]
        public int CheckoutTestC(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("D", ExpectedResult = 15)]
        public int CheckoutTestD(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("AAA", ExpectedResult = 130)]
        public int CheckoutThreeA(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("BB", ExpectedResult = 45)]
        public int CheckoutTwoB(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("BB", ExpectedResult = 45)]
        public int CheckoutFewItems(string items)
        {
            return CheckoutSolution.Checkout(items);
        }
    }
}

