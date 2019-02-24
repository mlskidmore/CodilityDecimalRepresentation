using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecimalRepresentation;

namespace UnitTests
{
    [TestClass]
    public class DecimalRepresentationUnitTests
    {
        [TestInitialize()]
        public void Initialize()
        {
        }

        [TestMethod]
        [Description("Should pass when subStr is less than zero.")]
        public void subStrIsLessThanZero()
        {
            // Arrange
            int subStr = -1;
            int mainStr = 1;
            int expected = -1;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Should pass when mainStr is less than zero.")]
        public void mainStrIsLessThanZero()
        {
            // Arrange
            int subStr = 1;
            int mainStr = -1;
            int expected = -1;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Should pass when both inputs are less than zero.")]
        public void BothInputsAreLessThanZero()
        {
            // Arrange
            int subStr = -1;
            int mainStr = -1;
            int expected = -1;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Should pass when substr is greater than 999999999.")]
        public void subStrIsGreaterThanBigNum()
        {
            // Arrange
            int subStr = 1000000000;
            int mainStr = 1;
            int expected = -1;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Should pass when mainStr is greater than 999999999.")]
        public void mainStrIsGreaterThanBigNum()
        {
            // Arrange
            int subStr = 1;
            int mainStr = 1000000000;
            int expected = -1;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Should pass when both inputs are greater than BigNum.")]
        public void BothInputsAreGreaterThanBigNum()
        {
            // Arrange
            int subStr = 1000000000;
            int mainStr = 1000000000;
            int expected = -1;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Should pass when both inputs are zero.")]
        public void BothInputsAreLengthZero()
        {
            // Arrange
            int subStr = 0;
            int mainStr = 0;
            int expected = 0;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Should pass when subStr is greater than mainStr.")]
        public void subStrIsGreaterThanmainStr()
        {
            // Arrange
            int subStr = 2;
            int mainStr = 1;
            int expected = -1;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Should pass when subStr is not in mainStr.")]
        public void subStrIsNotInmainStr()
        {
            // Arrange
            int subStr = 2;
            int mainStr = 1;
            int expected = -1;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [Description("Should pass when subStr is not in mainStr.")]
        public void subStrIsInmainStr()
        {
            // Arrange
            int subStr = 53;
            int mainStr = 1953786;
            int expected = 2;
            // Act
            int actual = DecimalRepresentation.Program.findDecimalRepresenation(subStr, mainStr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
