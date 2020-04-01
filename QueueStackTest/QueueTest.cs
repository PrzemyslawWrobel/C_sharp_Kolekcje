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

        [TestMethod]
        public void QueueToArray()

        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            var array = queue.ToArray();
            queue.Dequeue();

            Assert.AreEqual(1, array[0]);
            Assert.AreEqual(6, array.Length);
            Assert.AreEqual(5, queue.Count);
        }


        [TestMethod]
        public void QueueClear()

        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            queue.Clear();
            Assert.AreEqual(0, queue.Count);
        }
    }
}
