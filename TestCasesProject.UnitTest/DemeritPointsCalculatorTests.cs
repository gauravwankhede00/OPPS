using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestCasesProject.UnitTest
{
    [TestFixture]
    class DemeritPointsCalculatorTests
    {
        [Test]
        public void CalculateDemeritPoints_SpeedLessThanZero_GetArgumentOutOfRangeException()
        {
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            Assert.That(() => calculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_MaxSpeedGreater300_GetArgumentOutOfRangeException()
        {
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            Assert.That(() => calculator.CalculateDemeritPoints(301), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void CalculateDemeritPoints_SpeedLessThanSpeedLimit_GetZero()
        {
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            var result = calculator.CalculateDemeritPoints(60);

            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void CalculateDemeritPoints_MaxSpeedGreater300_Get37()
        {
            DemeritPointsCalculator calculator = new DemeritPointsCalculator();
            var result = calculator.CalculateDemeritPoints(250);

            Assert.That(result, Is.EqualTo(37));
        }
    }
}
