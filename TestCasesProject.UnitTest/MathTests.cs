using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestCasesProject.UnitTest
{
    [TestFixture]
    public class MathTests
    {
        Math math;
        [SetUp]
        public void SetUp()
        {
            math = new Math();
        }
        [Test]
        public void Sum_WhenCalled_SumOfArguments()
        {
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnGreatestArgument(int a, int b, int expectedResult)
        {
            var result = math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        [Test]
        [Ignore("No Use for till next production")]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            var result = math.Max(5, 10);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Max_BothArgumentAreSame_ReturnOddNumber()
        {
            var result = math.GetOddNumbers(5);
            Assert.That(result, Is.EquivalentTo(new int[] { 1, 3, 5 }));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);

        }
    }
}
