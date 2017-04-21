using System;
using System.Collections.Generic;

namespace DesignAstackEx
{
    public class Stack
    {
        private static readonly List<object> StackData = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Null is passed to the method");
            }
            StackData.Add(obj);
        }

        public object Pop()
        {
            if (StackData.Count == 0)
            {
                throw new InvalidOperationException("Null is passed to the method");
            }
            var lastObj = StackData[StackData.Count - 1];
            StackData.RemoveAt(StackData.Count - 1);
            return lastObj;
        }

        public void Clear()
        {
            StackData.Clear();
        }

        
    }

   
}