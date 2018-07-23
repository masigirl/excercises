using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary.UnitTest
{
    [TestClass]
    public class StackUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Push_NullObject_ThrowsException()
        {
            var Stack=new ClassLibrary.Stack();
            Stack.Push(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_EmptyStack_ThrowsException()
        {
            var Stack = new ClassLibrary.Stack();
            Stack.Pop();
        }
    }
}
