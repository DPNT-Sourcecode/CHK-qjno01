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

        [TestCase("ABCD", ExpectedResult = 115)]
        public int CheckoutFewItems(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("AAAA", ExpectedResult = 180)]
        public int CheckoutFourA(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("BBBB", ExpectedResult = 90)]
        public int CheckoutTwoSpecialB(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("AAAABBBCD", ExpectedResult = 180 + 75 + 20 + 15)]
        public int CheckoutCombos(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

       
        [TestCase("gasjfkdlhiujghwq", ExpectedResult = -1)]
        [TestCase("JKLSEA", ExpectedResult = -1)]
        [TestCase("Aa", ExpectedResult = -1)]
        [TestCase("abcd", ExpectedResult = -1)]
        public int CheckoutInvalidInput(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("", ExpectedResult = 0)]
        public int CheckoutEmpty(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("EEB", ExpectedResult = 80)]
        [TestCase("EE", ExpectedResult = 80)]
        [TestCase("EEBB", ExpectedResult = 110)]
        [TestCase("EEBBB", ExpectedResult = 80 + 45)]
        [TestCase("EEEEBB", ExpectedResult = 160)]
        public int CheckoutForFree(string items)
        {
            return CheckoutSolution.Checkout(items);
        }
    }
}


