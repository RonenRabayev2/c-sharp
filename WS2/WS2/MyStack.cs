using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;//Assert

namespace WS2
{
    internal class MyStack : MyStackInterface
    {
        private Object[] stack;
        private int capacity;
        private int index;

        public MyStack(int capacity = 10) : 
        {
            this.capacity = capacity;
            this.stack = new Object[capacity];
            index = 0;
        }

        public void Clear()
        {
            index = 0;
        }

        public bool IsEmpty()
        {
            Debug.Assert(index > -1);

            return index == 0;
        }

        public object Peek()
        {
            Debug.Assert(index > 0);
            return stack[index - 1];
        }

        public void Pop()
        {
            Debug.Assert(index > 0);

            --index;
        }

        public void Push(object val)
        {
            Debug.Assert(index < capacity - 1);

            stack[index] = val;
            ++index;
        }
    }
}
