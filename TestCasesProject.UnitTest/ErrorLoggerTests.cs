using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestCasesProject.UnitTest
{
    [TestFixture]
    class ErrorLoggerTests
    {
        [Test]
        public void ErrorLogger_WhenCalled_ShouldSetLastErrorProperty()
        {
            ErrorLogger errorLogger = new ErrorLogger();
            errorLogger.LastError = "a";

            Assert.That(errorLogger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void ErrorLogger_WhenCalled_ShouldThrowError(string input)
        {
            ErrorLogger errorLogger = new ErrorLogger();
            Assert.That(() => errorLogger.Log(input), Throws.ArgumentNullException);
        }

        [Test]
        public void ErrorLogger_ValidError_RaiseErrorLoggedEvent()
        {
            ErrorLogger errorLogger = new ErrorLogger();
            var id = Guid.Empty;
            errorLogger.ErrorLogged += (sender, arg) =>
            {
                id = arg;
            };
            errorLogger.Log("a");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
