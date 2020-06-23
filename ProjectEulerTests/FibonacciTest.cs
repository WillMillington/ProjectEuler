using System.Linq;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Ignore("Requirements have changed")]
        //[Test] 
        //public void Given1_List1()
        //{
        //    Assert.That(Program.Fibonacci(1).Count,Is.EqualTo(1));
        //}
        //[Ignore("Requirements have changed")]
        //[TestCase(2)]
        //[TestCase(3)]
        //[TestCase(4)]
        //[TestCase(5)]
        //public void GivenN_ListN(int n)
        //{
        //    Assert.That(Program.Fibonacci(n).Count, Is.EqualTo(n));
        //}
        //[Ignore("Requirements have changed")]
        //[Test]
        //public void Max_4_Last_Num_is_3()
        //{
        //    Assert.That(Program.Fibonacci(4).Last(), Is.EqualTo(3));
        //}
        //[Ignore("Requirements have changed")]
        //[TestCase(2, 1)]
        //[TestCase(3, 2)]
        //[TestCase(5, 5)]
        //[TestCase(6, 8)]
        //[TestCase(7, 13)]
        //[TestCase(8, 21)]
        //public void MaxN_Last_Num_is_correct(int n, int expected)
        //{
        //    Assert.That(Program.Fibonacci(n).Last(), Is.EqualTo(expected));
        //}
        //[Ignore("Requirements have changed")]
        //[Test]
        //public void Get_All_Even_Values()
        //{
        //    Assert.That(Program.Fibonacci(8).Count, Is.EqualTo(2));
        //}
        //[Test]
        //public void Sum_max8_is_10()
        //{
        //    Assert.That(Program.Fibonacci(8), Is.EqualTo(10));
        //}
        //[Test]
        //public void Last_under_4mil()
        //{
        //    Assert.That(Program.Fibonacci(58).Last(), Is.EqualTo(3524578));
        //}
        [TestCase(8, 10)]
        [TestCase(9, 44)]
        [TestCase(10, 44)]
        [TestCase(11, 44)]
        [TestCase(12, 188)]
        [TestCase(13, 188)]
        [TestCase(14, 188)]
        [TestCase(15, 798)]
        public void EvenSumWorks(int max, int expected)
        {
            Assert.That(Program.Fibonacci(max), Is.EqualTo(expected));
        }
    }
}