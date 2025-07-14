using NetStandardLib;

namespace DotNetTests
{
    public class NetStandardTests
    {
        [Test]
        public void SayHello_ReturnsExpectedMessage()
        {
            var result = GreeterStandard.SayHello();
            Assert.That(result, Is.EqualTo("Hello from .NET Standard Project!"));
        }
    }
}