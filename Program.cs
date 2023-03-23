using Test;

//StarDiamond main = new StarDiamond();

//main.run();

StackTest<int> intStack = new StackTest<int>();
intStack.push(10);
intStack.push(20);
intStack.push(30);
intStack.push(40);
Console.WriteLine(intStack.top());
Console.WriteLine(intStack.pop());
Console.WriteLine(intStack.top());
Console.WriteLine(intStack.size());


StackTest<string> stringStack = new StackTest<string>();
stringStack.push("aaa");
stringStack.push("bb");
stringStack.push("ccc");
stringStack.push("dddddd");
stringStack.push("zzzzz");
Console.WriteLine(stringStack.top());
Console.WriteLine(stringStack.pop());
Console.WriteLine(stringStack.top());
Console.WriteLine(stringStack.size());

Console.WriteLine();
Stack<int> s = new Stack<int>();
s.Push(10);
Console.WriteLine(s.Peek());

//2차원 배열 출력, 역순 출력

/*
int[,] arr = new int[3, 4];

int x = 1;

for (int i = 0; i < arr.GetLength(0); i++)
{
        for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = x;
        x += 2;
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[arr.GetLength(0)-i-1, arr.GetLength(1)-j-1] + " ");
    }
    Console.WriteLine();
}
*/