using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class StackTest<T>
    {
        LinkedList<T> stack = new LinkedList<T>();
        public void push(T x)
        {
            stack.AddLast(x);
        }
        
        public T top()
        {
            return stack.Last.Value;
        }

        public T pop()
        {
            T tmp = stack.Last.Value;
            stack.RemoveLast();
            return tmp;
        }

        public int size()
        {
            return stack.Count;
        }
    }
}
