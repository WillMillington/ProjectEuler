using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    class LargestPrimeFactorTests
    {
        [Test]
        public void Given1_Return1()
        {
            Assert.That(LargestPrimeFactor.LargestPrimeFactorMehtod(1), Is.EqualTo(1));
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        public void GivenPrimeN_ReturnPrimeN(long num)
        {
            Assert.That(LargestPrimeFactor.LargestPrimeFactorMehtod(num), Is.EqualTo(num));
        }
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 2)]
        [TestCase(5, 5)]
        [TestCase(6, 3)]
        public void LargestPrimeFactorFound(long num, long expected)
        {
            Assert.That(LargestPrimeFactor.LargestPrimeFactorMehtod(num), Is.EqualTo(expected));
        }
        [Test]
        public void ProjectEulerNumberCheck()
        {
            Assert.That(LargestPrimeFactor.LargestPrimeFactorMehtod(600851475143), Is.EqualTo(6857));
        }
    }
}
