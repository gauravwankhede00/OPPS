using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestCasesProject.UnitTest
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        [TestCase(15, "FizzBuzz")]
        [TestCase(9, "Fizz")]
        [TestCase(20, "Buzz")]
        [TestCase(7, "7")]
        public void GetOutput_InputDivisiable3And5_ReturnString(int number, string output)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.That(result, Is.EqualTo(output));
        }
    }
}
