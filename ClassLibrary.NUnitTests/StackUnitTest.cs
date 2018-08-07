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
    }
}
