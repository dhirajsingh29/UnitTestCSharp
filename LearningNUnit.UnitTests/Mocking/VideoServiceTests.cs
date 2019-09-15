
using LearningUnitTest.Mocking;
using NUnit.Framework;

namespace LearningNUnit.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        // Testing method utilizing Constructor Dependency Injection
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnError()
        {
            var videoService = new VideoService(new FakeFileReader());

            var result = videoService.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

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

        // Testing method utilizing Method Dependency Injection
        //[Test]
        //public void ReadVideoTitle_EmptyFile_ReturnError()
        //{
        //    var videoService = new VideoService();

        //    var result = videoService.ReadVideoTitle(new FakeFileReader());

        //    Assert.That(result, Does.Contain("error").IgnoreCase);
        //}
    }
}
