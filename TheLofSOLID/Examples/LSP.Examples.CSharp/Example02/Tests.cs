using NUnit.Framework;
using System.Collections;

namespace Tests
{

    public class Tests
    {
        public static IEnumerable TestCases() 
        {
            yield return new Rectangle();
            yield return new Square();
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test1(Rectangle rectangle)
        {
            rectangle.Width = 4;
            rectangle.Height = 5;
            Assert.AreEqual(20, rectangle.Area);
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public void Test2(Rectangle rectangle)
        {
            // square violates setter postconditions of rectangle!
            rectangle.Width = 4;
            rectangle.Height = 5;
            Assert.AreEqual(4, rectangle.Width);
            Assert.AreEqual(5, rectangle.Height);
        }
    }
}