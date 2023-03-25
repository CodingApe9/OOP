using Test.report1_20230327_stack;

//StarDiamond main = new StarDiamond();
//main.run();

//int LinkedList Stack Test
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("#int LinkedList Stack Test Start");
LinkedListStack<int> intLinkedListStack = new LinkedListStack<int>();
intLinkedListStack.Push(10);
intLinkedListStack.Push(20);
intLinkedListStack.Push(30);
intLinkedListStack.Push(40);
Console.WriteLine(intLinkedListStack.Pop());
Console.WriteLine(intLinkedListStack.Peek());
intLinkedListStack.Clear();
Console.WriteLine(intLinkedListStack.Peek());
Console.WriteLine(intLinkedListStack.Size());
Console.WriteLine("#int LinkedList Stack Test End");
Console.WriteLine("-----------------------------------------------------");

//string LinkedList Stack Test
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("#string LinkedList Stack Test Start");
LinkedListStack<string> stringLinkedListStack = new LinkedListStack<string>();
stringLinkedListStack.Push("aaa");
stringLinkedListStack.Push("bb");
stringLinkedListStack.Push("ccc");
stringLinkedListStack.Push("dddddd");
stringLinkedListStack.Push("zzzzz");
Console.WriteLine(stringLinkedListStack.Pop());
Console.WriteLine(stringLinkedListStack.Peek());
stringLinkedListStack.Clear();
Console.WriteLine(stringLinkedListStack.Peek());
Console.WriteLine(stringLinkedListStack.Size());
Console.WriteLine("#string LinkedList Stack Test End");
Console.WriteLine("-----------------------------------------------------");

//int Array Stack Test
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("#int Array Stack Test Start");
ArrayStack<int> intArrayStack = new ArrayStack<int>(10);
intArrayStack.Push(10);
intArrayStack.Push(20);
Console.WriteLine(intArrayStack.Pop());
Console.WriteLine(intArrayStack.Peek());
intArrayStack.Push(444);
Console.WriteLine(intArrayStack.Peek());
intArrayStack.Clear();
Console.WriteLine(intArrayStack.Pop());
Console.WriteLine("#int Array Stack Test End");
Console.WriteLine("-----------------------------------------------------");

//string Array Stack Test
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("#string Array Stack Test Start");
ArrayStack<string> stringArrayStack = new ArrayStack<string>(10);
stringArrayStack.Push("asdf");
stringArrayStack.Push("hhh241f");
stringArrayStack.Push("9237dsgsgsd");
Console.WriteLine(stringArrayStack.Pop());
Console.WriteLine(stringArrayStack.Peek());
stringArrayStack.Push("aaaaaaa");
Console.WriteLine(stringArrayStack.Peek());
stringArrayStack.Clear();
Console.WriteLine(stringArrayStack.Pop());
Console.WriteLine("#string Array Stack Test End");
Console.WriteLine("-----------------------------------------------------");
