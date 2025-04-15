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
            ModularCounter mc = new ModularCounter(5, 0, 2);
            // Act

            // Assert
        }
    }
}