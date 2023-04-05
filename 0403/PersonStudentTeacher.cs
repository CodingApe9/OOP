public class Person
{
    public string name;
    public int age;
    public int size;
    public string hairColor;

    public Person(string name, int age, int size)
    {
        this.name = name;
        this.age = age;
        this.size = size;
    }

    public void Walk(int distance)
    {
        Console.WriteLine("Walk distance: "+ distance);
    }

    public void Eat(string food)
    {
        Console.WriteLine("Eat food: "+ food);
    }

    public void Speak(string language)
    {
        Console.WriteLine("Speak language: " + language);
    }
}

public class Student: Person
{
    public string stdNum;

    public Student(string name, int age, int size, string stdNum): base(name, age, size)
    {
        this.stdNum = stdNum;
    }

    public void Study(string subject)
    {
        Console.WriteLine("Study subject: " + subject);
    }
}

public class Teacher: Person
{
    public int officeNum;

    public Teacher(string name, int age, int size, int officeNum): base(name, age, size)
    {
        this.officeNum = officeNum;
    }

    public void Teach(string subject)
    {
        Console.WriteLine("Teach subject: " + subject);
    }
}

public class Man
{
    public static void Main()
    {
        Person person1 = new Person("person1", 23, 170);
        Student student1 = new Student("student1", 25, 180, "1001001");
        Teacher teacher1 = new Teacher("teacher1", 40, 163, 01012341234);

        person1.Walk(12);
        person1.Eat("햄버거");
        person1.Speak("안녕!");
        Console.WriteLine();

        student1.Walk(123);
        student1.Eat("피자");
        student1.Speak("hello");
        student1.Study("c#");
        Console.WriteLine();

        teacher1.Walk(12);
        teacher1.Eat("빵");
        teacher1.Speak("world!");
        teacher1.Teach("객체지향");
    }
}