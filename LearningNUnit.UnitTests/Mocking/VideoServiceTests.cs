
using LearningUnitTest.Mocking;
using Moq;
using NUnit.Framework;

namespace LearningNUnit.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _videoService;
        private Mock<IFileReader> _fileReader;

        [SetUp]
        public void Setup()
        {
            _fileReader = new Mock<IFileReader>();
            _videoService = new VideoService(_fileReader.Object);
        }

        // Testing method using Moq
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            _fileReader.Setup((fr) => fr.Read("video.txt")).Returns("");

            var result = _videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        //// Testing method utilizing Constructor Dependency Injection
        //[Test]
        //public void ReadVideoTitle_EmptyFile_ReturnError()
        //{
        //    var videoService = new VideoService(new FakeFileReader());

        //    var result = videoService.ReadVideoTitle();

        //    Assert.That(result, Does.Contain("error").IgnoreCase);
        //}

        //// Testing method utilizing Property Dependency Injection
        //[Test]
        //public void ReadVideoTitle_EmptyFile_ReturnError()
        //{
        //    var videoService = new VideoService
        //    {
        //        // Replace the actual File Reader created by VideoService class
        //        // by a FakeFileReader instance
        //        FileReader = new FakeFileReader()
        //    };

        //    var result = videoService.ReadVideoTitle();

        //    Assert.That(result, Does.Contain("error").IgnoreCase);
        //}

        //// Testing method utilizing Method Dependency Injection
        //[Test]
        //public void ReadVideoTitle_EmptyFile_ReturnError()
        //{
        //    var videoService = new VideoService();

        //    var result = videoService.ReadVideoTitle(new FakeFileReader());

        //    Assert.That(result, Does.Contain("error").IgnoreCase);
        //}
    }
}
