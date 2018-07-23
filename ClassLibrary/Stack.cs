using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Stack
    {
        private readonly List<Object> _stack = new List<Object>();
       
        public void Push(Object obj)
        {
            if (obj != null)
            {
                _stack.Add(obj);
            }
            else
            {
                throw new InvalidOperationException("Null objects cannot be accepted");
            }
            
        }

        public void Clear()
        {
            _stack.Clear();
        }

        public Object Pop()
        {
            if (_stack.Count==0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            else
            {
                var index = _stack.Count - 1;
                var topElement = _stack.ElementAt(index);
                _stack.RemoveAt(index);
                return topElement;
            }
        }
        public void PrintAll()
        {
            foreach(Object myObj in _stack)
            {
                Console.WriteLine(myObj.ToString());
            }
        }
    }
}
