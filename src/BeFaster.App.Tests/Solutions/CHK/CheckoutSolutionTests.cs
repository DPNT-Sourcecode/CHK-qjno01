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
        [TestCase("K", ExpectedResult = 70)]
        [TestCase("L", ExpectedResult = 90)]
        [TestCase("M", ExpectedResult = 15)]
        [TestCase("N", ExpectedResult = 40)]
        [TestCase("O", ExpectedResult = 10)]
        [TestCase("P", ExpectedResult = 50)]
        [TestCase("Q", ExpectedResult = 30)]
        [TestCase("R", ExpectedResult = 50)]
        [TestCase("S", ExpectedResult = 20)]
        [TestCase("T", ExpectedResult = 20)]
        [TestCase("U", ExpectedResult = 40)]
        [TestCase("V", ExpectedResult = 50)]
        [TestCase("W", ExpectedResult = 20)]
        [TestCase("X", ExpectedResult = 17)]
        [TestCase("Y", ExpectedResult = 20)]
        [TestCase("Z", ExpectedResult = 21)]
        public int CheckoutSoloItems(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("AAA", ExpectedResult = 130)]
        [TestCase("AAAAA", ExpectedResult = 200)]
        [TestCase("AAAAAAAA", ExpectedResult = 330)]
        [TestCase("AAAAAAAAA", ExpectedResult = 380)]
        [TestCase("BB", ExpectedResult = 45)]
        [TestCase("HHHHH", ExpectedResult = 45)]
        [TestCase("HHHHHHHHHH", ExpectedResult = 80)]
        [TestCase("HHHHHHHHHHHHHHH", ExpectedResult = 125)]
        [TestCase("KK", ExpectedResult = 120)]
        [TestCase("KKK", ExpectedResult = 120+70)]
        [TestCase("PPPPP", ExpectedResult = 200)]
        [TestCase("PPPPPP", ExpectedResult = 250)]
        [TestCase("QQQ", ExpectedResult = 80)]
        [TestCase("QQQQ", ExpectedResult = 110)]
        [TestCase("VV", ExpectedResult = 90)]
        [TestCase("VVV", ExpectedResult = 130)]
        [TestCase("VVVVV", ExpectedResult = 90 + 130)]
        public int CheckoutSpecials(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("ABCD", ExpectedResult = 115)]
        [TestCase("AAAABBBCD", ExpectedResult = 180 + 75 + 20 + 15)]
        [TestCase("AAAAAAAABBEE", ExpectedResult = 130 + 200 + 30 + 80)] // (8A-130+200) (2B-30)  (2E-80)
        public int CheckoutCombos(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

       
        [TestCase("gasjfkdlhiujghwq", ExpectedResult = -1)]
        [TestCase("JKL32432SEA", ExpectedResult = -1)]
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
        [TestCase("RRRQ", ExpectedResult = 150)]
        [TestCase("RRRQQ", ExpectedResult = 180)]
        public int CheckoutForFree(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("FFF", ExpectedResult = 20)]
        [TestCase("FF", ExpectedResult = 20)]
        [TestCase("FFFF", ExpectedResult = 30)]
        [TestCase("FFFFF", ExpectedResult = 40)]
        [TestCase("UUUU", ExpectedResult = 120)]
        public int CheckoutRewording(string items)
        {
            return CheckoutSolution.Checkout(items);
        }

        [TestCase("SSS", ExpectedResult = 45)]
        [TestCase("TTT", ExpectedResult = 45)]
        [TestCase("XXX", ExpectedResult = 45)]
        [TestCase("YYY", ExpectedResult = 45)]
        [TestCase("ZZZ", ExpectedResult = 45)]
        [TestCase("XYZ", ExpectedResult = 45)]
        [TestCase("STX", ExpectedResult = 45)]
        [TestCase("YTZ", ExpectedResult = 45)]
        [TestCase("STY", ExpectedResult = 45)]
        [TestCase("STZ", ExpectedResult = 45)]
        [TestCase("XXXX", ExpectedResult = 45 + 17)]
        [TestCase("YYYX", ExpectedResult = 45 + 17)]
        [TestCase("XYZT", ExpectedResult = 45 + 17)]
        public int CheckoutGroupDiscount(string items)
        {
            return CheckoutSolution.Checkout(items);
        }
    }
}

