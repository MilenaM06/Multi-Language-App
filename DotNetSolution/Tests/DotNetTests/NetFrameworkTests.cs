using NetFrameworkApp;

namespace DotNetTests
{
    public class NetFrameworkTests
    {
        private GreeterFramework greeterFramework;

        [SetUp]
        public void Setup()
        {
            greeterFramework = new GreeterFramework();
        }

        [Test]
        public void SayHello_ReturnsExpectedMessage()
        {
            var result = greeterFramework.SayHello();
            Assert.That(result, Is.EqualTo("Hello from .NET Framework Project!"));
        }
    }
}
