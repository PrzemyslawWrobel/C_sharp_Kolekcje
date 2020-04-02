using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStackTest
{
    [TestClass]
    class StackTest
    {
        [TestMethod]
        public void StackUsePeak()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Assert.AreEqual(1, stack.Peek());
        }

        [TestMethod]
        public void StackContains()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Assert.IsTrue(stack.Contains(5));
        }
    }
}
