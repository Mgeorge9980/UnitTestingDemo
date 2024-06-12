using NUnit.Framework;
using UnitTestingDemo;
namespace TestClass
{
    public class Class1
    {
        [TestFixture]
        public class TriangleTest1
        {
            // MERLIN GEORGE
            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                // Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;
                string expected = "The triangle is valid.";
                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                Assert.AreEqual(expected, actual);
            }
        }

    }
}
