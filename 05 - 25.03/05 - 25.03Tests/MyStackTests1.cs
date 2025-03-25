using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    [TestClass()]
    public class MyStackTests1
    {
        [TestMethod()]
        public void MyStackGenericTest()
        {
            // Arrange
            MyStack<string> stStr = new MyStack<string>();
            stStr.Push("mere");
            stStr.Push("are");
            stStr.Push("Ana");

            string expected = "Ana are mere";

            // Act
            StringBuilder sb = new StringBuilder();
            while (stStr.Count > 0)
            {
                sb.Append(stStr.Pop());
                sb.Append(' ');
            }
            
            // Assert
            Assert.AreEqual(expected, sb.ToString().Trim());    
        }
    }
}
