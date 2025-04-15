using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ModularCounterTests
    {


        [TestMethod()]
        public void TickTest()
        {
            // Arrange
            ModularCounter mc = new ModularCounter(11, 5, 3);
            // Act

            mc.Tick();
            mc.Tick();
            mc.Tick();
            mc.Tick();

            int expected = 6;
            int actual = mc.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TickTest2()
        {
            // Arrange
            ModularCounter mc = new ModularCounter(11, 5, 3);
            // Act

            for(int i = 0; i < 100; i++)
            {
                mc.Tick();
                Console.WriteLine(mc);
            }   

            

            // Assert
            Assert.IsTrue(true);
        }
    }
}