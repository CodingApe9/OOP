# OOP
2020875024 배수훈

  배열, 링크드 리스트로 스택 구현
 
    Program.cs: 테스트 코드
  
    report1_20230327_stack
    
      ArrayStack.cs: 배열 스택 클래스
      
      LinkedListStack.cs 링크드 리스트 스택 클래스
      
      각각 배열 스택, 링크드 리스트 스택 클래스 파일
      
      
![image](https://user-images.githubusercontent.com/117576404/227758181-1911934a-b6a5-4f75-99e6-12f85b05e094.png)

테스트 코드 설명: 두 스택 클래스에 Push, Pop 정상 동작 test, 빈 상태의 스택일때 Pop, Peek 동작시 에러(Null Pointer Exception) 테스트

링크드 리스트 스택 클래스 설명: 노드 클래스는 value, next 두 가지 멤버 데이터를 가진다. 

    1. value: 제너릭 T타입의 값을 가진다.
    
    2. next는: 다음 노드의 주소(Node<T>?)를 가진다. 이때 next는 nullable.
    
    value는 getter만 지원, next는 getter, setter 둘 다 지원.
    
    링크드 리스트는 이 노드를 이용해 구현.
    
  LinkedListStack<T> 클래스는 top, size 두 가지 멤버데이터를 가진다.
        
      1. Node<T>? top: 스택의 top Node를 기억하는 변수, 스택의 헤드 포인터이다.
        
      2. int size: 스택의 Node의 개수를 기억하는 int형 변수.
        
  LinkedListStack<T> 클래스는 Push, Pop, Peek, Size, Clear 5가지 메소드를 지원.
    
      1. public void Push(T value) : T형의 value를 받아서 새 Node를 만든다.
        
          만든 새 Node의 next를 현재 스택의 top으로 바꿔준다. 그리고 스택의 top변수를 만든 새 노드로 변경한다.
  
          size도 1 증가시킨다.
        
      2. public T? Pop() : top이 가리키는 Node를 삭제하고 그 노드의 value를 리턴한다.
        
         이때 헤드가 null이면 "#Error Empty Stack"를 출력하고 default(T)를 리턴한다. (Null Pointer Exception를 피하기 위해)
        
          #default(T)는 T가 Primitive Type이면 타입의 기본 값을 제공하고 Refference Type은 null을 제공한다.
  
          size는 1 감소. Pop이 동작하기 전에 top이 null이 이라면 즉 Pop할 노드가 없다면 size는 감소하지 않는다. 
  
      3. public T? Peek() : top이 가리키는 Node의 value를 리턴한다.
  
          Pop와 마찬가지로 null이라면 에러 메시지를 출력하고 default(T)를 이용해 값을 리턴한다.
  
      4. public int Size() : 스택의 노드 개수를 기억하는 변수인 size를 리턴한다.
  
      5. public void Clear() : 스택의 헤드를 가리키는 top을 null로 초기화하고 스택의 노드 개수를 기억하는 변수인 size를 0으로 변경한다.
  
  
