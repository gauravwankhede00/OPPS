using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestCasesProject.UnitTest
{
    [TestFixture]
    class HtmlFormatorTests
    {
        [Test]
        [TestCase("abc")]
        [TestCase("pqr")]
        [TestCase("XYZ")]
        public void FormatAsBold_WhenCalled_ShouldEnclosedStingWithStong(string parameter)
        {
            var formator = new HtmlFormatter();

            var result = formator.FormatAsBold(parameter);

            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain(parameter));


        }
    }

}
