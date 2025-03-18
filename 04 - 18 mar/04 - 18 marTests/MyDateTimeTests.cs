using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class MyDateTimeTests
    {
        [TestMethod()]
        public void DiffTestSameYear()
        {
            // Arrange
            MyDateTime d1 = new MyDateTime(18, 3, 2025);
            MyDateTime d2 = new MyDateTime(18, 4, 2025);
            
            // Act
            int expected = 31;
            
            // Assert
            Assert.AreEqual(expected, d2 - d1);

        }

        [TestMethod()]
        public void DiffTestDifferenYear()
        {
            // Arrange
            MyDateTime d1 = new MyDateTime(18, 3, 2024);
            MyDateTime d2 = new MyDateTime(18, 3, 2025);
            int expected = 365;

            // Act
            int actual = d2 - d1;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DiffTestLeapYear()
        {
            // Arrange
            MyDateTime d1 = new MyDateTime(18, 1, 2024);
            MyDateTime d2 = new MyDateTime(18, 1, 2025);
            int expected = 366;

            // Act
            int actual = d2 - d1;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void MyDateTimeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsLeapYearTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EqualsTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CloneTest()
        {
            Assert.Fail();
        }
    }
}