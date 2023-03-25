using LinkedList.Stack;

//StarDiamond main = new StarDiamond();
//main.run();

//int LinkedList Stack Test
LinkedListStack<int> intStack = new LinkedListStack<int>();
intStack.Push(10);
intStack.Push(20);
intStack.Push(30);
intStack.Push(40);
Console.WriteLine(intStack.Pop());
Console.WriteLine(intStack.Peek());
intStack.Clear();
Console.WriteLine(intStack.Peek());
Console.WriteLine(intStack.Size());

//string LinkedList Stack Test
LinkedListStack<string> stringStack = new LinkedListStack<string>();
stringStack.Push("aaa");
stringStack.Push("bb");
stringStack.Push("ccc");
stringStack.Push("dddddd");
stringStack.Push("zzzzz");
Console.WriteLine(stringStack.Pop());
Console.WriteLine(stringStack.Peek());
stringStack.Clear();
Console.WriteLine(stringStack.Peek());
Console.WriteLine(stringStack.Size());

