# OOP
2020875024 배수훈

  배열, 링크드 리스트로 스택 구현
 
    Program.cs: 테스트 코드
  
    report1_20230327_stack
      ArrayStack.cs: 배열 스택 클래스
      LinkedListStack.cs 링크드 리스트 스택 클래스
      각각 배열 스택, 링크드 리스트 스택 클래스 파일
      
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
int size = 10;
ArrayStack<int> intArrayStack = new ArrayStack<int>(size);
intArrayStack.Push(10);
intArrayStack.Push(20);
Console.WriteLine(intArrayStack.Pop());
Console.WriteLine(intArrayStack.Peek());
intArrayStack.Push(444);
Console.WriteLine(intArrayStack.Peek());
intArrayStack.Clear();
Console.WriteLine(intArrayStack.Pop());
for (int i = 0; i <= size; i++)
{
    intArrayStack.Push(i);
}
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
![image](https://user-images.githubusercontent.com/117576404/227758181-1911934a-b6a5-4f75-99e6-12f85b05e094.png)
