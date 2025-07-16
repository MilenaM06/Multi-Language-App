using NetStandardLib;

namespace DotNetTests
{
    public class NetStandardTests
    {
        private GreeterStandard greeterStandard;

        [SetUp]
        public void Setup()
        {
            greeterStandard = new GreeterStandard();
        }

        [Test]
        public void SayHello_ReturnsExpectedMessage()
        {
            var result = greeterStandard.SayHello();
            Assert.That(result, Is.EqualTo("Hello from .NET Standard Project!"));
        }
    }
}