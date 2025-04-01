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
    public class MyQueueTests
    {
        [TestMethod()]
        public void MyQueueTest()
        {
            // Arrange
            MyQueue<int> Q = new MyQueue<int>();

            // Act
            for (int i = 1; i <= 5; i++)
            {
                Q.Enqueue(i);
            }
            Console.WriteLine(Q);
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine(Q.Dequeue());
            }
            Console.WriteLine(Q);

            for (int i = 6; i < 16; i++)
            {
                Q.Enqueue(i);
            }
            Console.WriteLine(Q);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Q.Dequeue());
            }
            Console.WriteLine(Q);

            // Assert
            Assert.AreEqual(2, Q.Count);
        }



        [TestMethod()]
        public void DequeueTest()
        {
            // Arrrange
            MyQueue<int> Q = new MyQueue<int>();
            // Act
            for (int i = 1; i <= 10; i++)
            {
                Q.Enqueue(i);
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(Q.Dequeue());
            }
            // Assert
            Assert.AreEqual(5, Q.Count);

        }

        [TestMethod()]
        public void EnqueueTest()
        {
            // Arrrange
            MyQueue<int> Q = new MyQueue<int>();
            // Act
            for(int i = 1; i <= 10; i++)
            {
                Q.Enqueue(i);
            }
            // Assert
            Assert.AreEqual(10, Q.Count);
        }
    }
}