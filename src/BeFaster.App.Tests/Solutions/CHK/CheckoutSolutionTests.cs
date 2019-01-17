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
        private SumSolution _solution;

        [SetUp]
        public void SetUp()
        {
            _solution = new SumSolution();
        }
    }
}

