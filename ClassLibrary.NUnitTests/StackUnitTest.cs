using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.NUnitTests
{
    [TestFixture]
    public class StackUnitTest
    {
        [TestCase]
        public void Push_NullObject_ThrowsException()
        {
            var Stack = new ClassLibrary.Stack();
            Assert.Throws(typeof(InvalidOperationException), ()=> Stack.Push(null));
        }

        [TestCase]
        public void Pop_EmptyStack_ThrowsException()
        {
            var Stack = new ClassLibrary.Stack();
            Assert.Throws(typeof(InvalidOperationException), () => Stack.Pop());
        }

        [TestCase]
        public void Pop_AnyObject_ReturnsLastObjectPushed()
        {
            var Stack = new ClassLibrary.Stack();
            Stack.Push(1);
            Stack.Push(2);
            Stack.Push(3);
            Assert.AreEqual(3, Stack.Pop());
            Assert.AreEqual(2, Stack.Pop());
            Assert.AreEqual(1, Stack.Pop());
        }
    }
}
