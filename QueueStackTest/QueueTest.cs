using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QueueStackTest
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void QueueUsePeak()

        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            Assert.AreEqual(1, queue.Peek());
        }

        [TestMethod]
        public void QueueContains()

        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            Assert.IsTrue(queue.Contains(3));
        }
    }
}
