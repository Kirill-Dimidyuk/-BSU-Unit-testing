using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace CheckTriangle.Tests
{
    [TestClass]
    public class CheckTriangleTest
    {
        [TestMethod]
        [TestCase(4, 4, 5, ExpectedResult = true)]
        [TestCase(3, 4, 5, ExpectedResult = true)]
        [TestCase(6, 6, 6, ExpectedResult = true)]
        [TestCase(6, 10, 17, ExpectedResult = false)]
        [TestCase(3, 10, 4, ExpectedResult = false)]
        [TestCase(13, 8, 14, ExpectedResult = true)]
        public static bool CheckingTriangle_PositiveTest(int a, int b, int c)
        {
            return CheckTriangle.CheckingTriangle(a, b, c);
        }

        [TestCase(13, -8, 14)]
        [TestCase(8, 10, 0)]
        [TestCase(0, -5, -5)]
        [TestCase(-13, 8, 6)]
        public void CheckingTriangle_InputInvalidValues_ThrowsArgumentException(int a, int b, int c)
        {
            NUnit.Framework.Assert.Throws<ArgumentException>(() => CheckTriangle.CheckingTriangle(a, b, c));
        }
    }
}
