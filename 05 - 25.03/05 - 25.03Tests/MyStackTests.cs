using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class MyStackTests
    {
        [TestMethod()]
        public void MyStackTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MyStackTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PushTest()
        {
            // Arrange
            MyStack stack = new MyStack();

            // Act
            stack.Push(1); 
            stack.Push(2);
            stack.Push(3);

            // Assert
            Assert.AreEqual(3, stack.Count);
        }

        [TestMethod()]
        public void ResizeTest()
        {
            // Arrange
            MyStack stack = new MyStack();

            int expectedCount = 10;
            int expectedCapacity = 16;
            // Act
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }   


            // Assert
            Assert.AreEqual(expectedCount, stack.Count);
            Assert.AreEqual(expectedCapacity, stack.Capacity);
        }

        [TestMethod()]
        public void PopTest()
        {
            // Arrange
            MyStack stack = new MyStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int expected = 3;
            // Act

            int actual = stack.Pop();

            // Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}