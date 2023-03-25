namespace Test.report1_20230327_stack
{
    internal class ArrayStack<T>
    {
        T[] array;
        int top, maxSize;
        public ArrayStack(int size)
        {
            this.maxSize = size;
            this.array = new T[size];
            this.top = -1;
        }
        public void Push(T value)
        {
            if (top+1 == maxSize)
            {
                Console.WriteLine("full Stack");
                return;
            }
            array[++top] = value;
        }
        public T Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Empty Stack");
                return default(T);
            }
            return array[top--];
        }
        public T Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Empty Stack");
                return default(T);
            }
            return array[top];
        }
        public int Size()
        {
            if (top == -1)
            {
                Console.WriteLine("Empty Stack");
            }
            return top;
        }
        public void Clear()
        {
            this.top = -1;
        }
    }
}
