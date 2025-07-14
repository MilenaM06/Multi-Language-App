using CliProject;

namespace DotNetTests
{
    public class CliTests
    {
        private GreeterCli greeter;

        [SetUp]
        public void Setup()
        {
            greeter = new GreeterCli();
        }

        [Test]
        public void SayHello_ReturnsExpectedString()
        {
            var result = greeter.SayHello();
            Assert.That(result, Is.EqualTo("Hello from C++/CLI Project!"));
        }
    }
}
