
using System;
using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningNUnit.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            
            // this will throw exception as per our code and hence mark our test case failed
            // logger.Log(error);

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
            Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;

            // firstly, subscribe to the event before Acting on it
            logger.ErrorLogged += (sender, args) => { id = args; };
            //Act
            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
