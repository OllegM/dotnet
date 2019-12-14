using NUnit.Framework;
using Dependency;

namespace Tests
{
    public class HelloControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            IGreating great = new Greating();
            var controller = new HelloController(great);
            controller.GetHelloText("test");

            Assert.That(controller.GetHelloText("test"), Is.EqualTo("Hello, test!").IgnoreCase);
        }
    }
}