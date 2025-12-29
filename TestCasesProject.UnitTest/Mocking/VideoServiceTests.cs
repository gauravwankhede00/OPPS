using Moq;
using NUnit.Framework;
using TestCasesProject.Mocking.NewFolder;
using TestNinja.Mocking;

namespace TestCasesProject.UnitTest.Mocking
{
    [TestFixture]
    class VideoServiceTests
    {
        private Mock<IFileReader> fileReader;
        private VideoService service;

        [SetUp]
        public void Setup()
        {
            fileReader = new Mock<IFileReader>();
            service = new VideoService(fileReader.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnErrorMessage()
        {
            fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            var result = service.ReadVideoTitle();
            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void GetUnprocessedVideosAsCsv()
        {
            var list = new List<Video>()
            {
                new Video{ Id = 1,IsProcessed = false, Title = "1" },
                 new Video{ Id = 2,IsProcessed = false, Title = "2" }
            };


            var mockIVideoRepository = new Mock<IVideoRepository>();
            mockIVideoRepository.Setup(o => o.GetVideos()).Returns(list);

            var result = service.GetUnprocessedVideosAsCsv(mockIVideoRepository.Object);

            Assert.That(result, Does.Contain("1,2").IgnoreCase);
            Assert.That(result, Is.EqualTo("1,2"));
        }
    }
}
