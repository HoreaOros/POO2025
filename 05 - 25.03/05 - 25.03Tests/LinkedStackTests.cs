using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05___25._03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___25._03.Tests
{
    [TestClass()]
    public class LinkedStackTests
    {
        [TestMethod()]
        public void PeekTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PopTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PushTest()
        {
            // Arrange
            IStack<int> stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            // Act 
            int expected = 3;
            int actual = stack.Count;
            // Assert
            Assert.AreEqual(expected, actual);

            
        }
    }
}