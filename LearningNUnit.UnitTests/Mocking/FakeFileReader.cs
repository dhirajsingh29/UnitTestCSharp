
using LearningUnitTest.Mocking;

namespace LearningNUnit.UnitTests.Mocking
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
