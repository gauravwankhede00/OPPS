using Moq;
using NUnit.Framework;
using TestCasesProject.Mocking.NewFolder;
using TestNinja.Mocking;

namespace TestCasesProject.UnitTest.Mocking
{
    [TestFixture]
    class InstallerHelperTests
    {
        [Test]
        public void DownloadFile()
        {
            string customerName = "A";
            string installerName = "B";

            var mock = new Mock<IInstaller>();
            InstallerHelper installer = new InstallerHelper(mock.Object);
            mock.Setup(o => o.DownloadFile("http://example.com/customer/test","")).Returns(true);
            var result = installer.DownloadInstaller(customerName, installerName);
            Assert.That(result, Is.True);
        }
    }
}
