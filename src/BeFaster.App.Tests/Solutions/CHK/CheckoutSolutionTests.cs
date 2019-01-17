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
        [TestCase("B", ExpectedResult = 30)]
        [TestCase("C", ExpectedResult = 20)]
        [TestCase("D", ExpectedResult = 15)]
        [TestCase("E", ExpectedResult = 40)]
        [TestCase("F", ExpectedResult = 10)]
        [TestCase("G", ExpectedResult = 20)]
        [TestCase("H", ExpectedResult = 10)]
        [TestCase("I", ExpectedResult = 35)]
        [TestCase("J", ExpectedResult = 60)]
        [TestCase("K", ExpectedResult = 80)]
        [TestCase("L", ExpectedResult = 90)]
        [TestCase("M", ExpectedResult = 15)]
        [TestCase("N", ExpectedResult = 40)]
        [TestCase("O", ExpectedResult = 10)]
        [TestCase("P", ExpectedResult = 50)]
        [TestCase("Q", ExpectedResult = 30)]
        [TestCase("R", ExpectedResult = 50)]
        [TestCase("S", ExpectedResult = 30)]
        [TestCase("T", ExpectedResult = 20)]
        [TestCase("U", ExpectedResult = 40)]
        [TestCase("V", ExpectedResult = 50)]
        [TestCase("W", ExpectedResult = 20)]
        [TestCase("X", ExpectedResult = 90)]
        [TestCase("Y", ExpectedResult = 10)]
        [TestCase("Z", ExpectedResult = 50)]
        public int CheckoutSoloItems(string items)
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
        [TestCase("AAAAAAAABBEE", ExpectedResult = 130 + 200 + 30 + 80)] // (8A-130+200) (2B-30)  (2E-80)
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

       
        [TestCase("EE", ExpectedResult = 80)]
        [TestCase("EEB", ExpectedResult = 80)]
        [TestCase("EEBB", ExpectedResult = 110)]
        [TestCase("EEBBB", ExpectedResult = 80 + 45)]
        [TestCase("EEEEBB", ExpectedResult = 160)]
        public int CheckoutForFree(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("AAAAA", ExpectedResult = 200)]
        [TestCase("AAAAAAAA", ExpectedResult = 330)]
        [TestCase("AAAAAAAAA", ExpectedResult = 380)]
        public int CheckoutFewSpecialsForOneProduct(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("FFF", ExpectedResult = 20)]
        [TestCase("FF", ExpectedResult = 20)]
        [TestCase("FFFF", ExpectedResult = 30)]
        [TestCase("FFFFF", ExpectedResult = 40)]
        public int CheckoutRewording(string items)
        {
            return CheckoutSolution.Checkout(items);
        }
    }
}


