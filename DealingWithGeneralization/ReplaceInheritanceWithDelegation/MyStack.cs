using System;
using System.Collections.Generic;
using System.Linq;

namespace DealingWithGeneralization.ReplaceInheritanceWithDelegation
{
    public class MyStack : List<object>
    {
        public void Push(Object element)
        {
            Insert(0, element);
        }

        public Object Pop()
        {
            var result = this.First();
            RemoveAt(0);
            return result;
        }

        public int Size()
        {
            return Count;
        }
        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}