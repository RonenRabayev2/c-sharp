using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS2
{
    internal interface MyStackInterface
    {
        //push object to the top of the stack
        public void Push(Object val);
        //remove the first object from the top of the stack
        public void Pop();
        //get the top object from the stack without removing them
        public Object Peek();
        //check is the stack is empty
        public bool IsEmpty();
        //clear all the stack
        public void Clear();


    }
}
