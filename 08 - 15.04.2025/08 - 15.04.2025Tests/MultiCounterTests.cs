using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class MultiCounterTests
    {


        [TestMethod()]
        public void TickTest()
        {
            MultiCounter mc = new MultiCounter(4, 11, 3);

            for (int i = 0; i < 1000; i++)
            {
                mc.Tick();

                Console.WriteLine(mc);
            }

            Assert.IsTrue(true);
        }
    }
}