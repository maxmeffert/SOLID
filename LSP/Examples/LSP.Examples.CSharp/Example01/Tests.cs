using NUnit.Framework;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Example01
{

    public class Tests
    {
        private ShapeClient _cut;
        [SetUp]
        public void Setup()
        {
            _cut = new ShapeClient();
        }

        public static IEnumerable TestCases() 
        {
            yield return new object[] { new Rectangle(), "Rectangle" };
            yield return new object[] { new Circle(), "Circle" };
            yield return new object[] { new Triangle(), "Triangle" };
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test(Shape shape, string expected)
        {
            var actual = _cut.DrawShape(shape);

            Assert.AreEqual(expected, actual);
        }
    }
}