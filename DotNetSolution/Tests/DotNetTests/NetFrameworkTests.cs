using NetFrameworkApp;

namespace DotNetTests
{
    public class NetFrameworkTests
    {
        [Test]
        public void SayHello_ReturnsExpectedMessage()
        {
            var result = GreeterFramework.SayHello();
            Assert.That(result, Is.EqualTo("Hello from .NET Framework Project!"));
        }
    }
}
