using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class CounterTests
    {
        

        [TestMethod()]
        public void TickTest()
        {
            // Arrange
            Counter c = new Counter();

            // Act  
            c.Tick();
            c.Tick();
            c.Tick();
            Console.WriteLine(c);

            // Assert
            int expected = 3;
            int actual = c.Count; 
            Assert.AreEqual(expected, actual);
        }
    }
}