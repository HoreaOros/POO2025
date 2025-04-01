using Microsoft.VisualStudio.TestTools.UnitTesting;
using _06___01._04._2025;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___01._04._2025.Tests
{
    [TestClass()]
    public class MyQueueLLTests
    {
        [TestMethod()]
        public void DequeueTest()
        {
            // Arrange
            MyQueueLL<int> q = new MyQueueLL<int>();

            // Act
            for (int i = 1; i <= 20; i++)
            {
                q.Enqueue(i);
            }
            Console.WriteLine(q);
        }

        [TestMethod()]
        public void EnqueueTest()
        {
            // Arrange
            MyQueueLL<int> q = new MyQueueLL<int>();

            // Act
            for (int i = 1; i <= 20; i++)
            {
                q.Enqueue(i);
            }

            // Assert
            Assert.AreEqual(20, q.Count);
        }
    }
}