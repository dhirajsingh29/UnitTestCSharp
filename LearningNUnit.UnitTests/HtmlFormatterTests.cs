
using LearningUnitTest.Fundamentals;
using NUnit.Framework;

namespace LearningNUnit.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");

            //Specific Assertion
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //More General Assertion
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.StartWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));
        }
    }
}
