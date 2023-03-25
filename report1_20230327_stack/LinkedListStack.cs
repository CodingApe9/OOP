namespace Test.report1_20230327_stack
{
    internal class Node<T>
    {
        T value;
        Node<T>? next;
        public  Node(T value)
        {
            this.value = value;
        }
        public T GetValue()
        {
            return value;
        }
        public Node<T> GetNext()
        {
            return next;
        }

        public void SetNext(Node<T> newNode)
        {
            next = newNode;
        }
    }
    internal class LinkedListStack<T>
    {
        Node<T>? top;
        int size;
        public LinkedListStack()
        {
            top = null;
            size = 0;
        }

        public void Push(T value) 
        {
            Node<T> newNode = new Node<T>(value);
            newNode.SetNext(top);
            top = newNode;
            size++;
        }
        public T? Pop() 
        {
            Node<T>? tmp = top;
            top = top.GetNext();
            size--;
            if (tmp == null)
            {
                Console.WriteLine("#Error Empty Stack");
                return default(T);
            }
            return tmp.GetValue();
        }
        public T? Peek() 
        {
            if (top == null)
            {
                Console.WriteLine("#Error Empty Stack");
                return default(T);
            }
            return top.GetValue();
        }
        public int Size()
        {
            return size;
        }
        public void Clear()
        {
            top = null;
            size = 0;
        }
    }
}
