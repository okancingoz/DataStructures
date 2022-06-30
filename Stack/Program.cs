var charset = new char[] {'a','b','c','d','e'};
var stack1 = new Stack<char>();
var stack2 = new Stack<char>(StackType.LinkedList);

foreach (var c in charset)
{
    System.Console.WriteLine(c);
    stack1.Push(c);
    stack2.Push(c);
}

System.Console.WriteLine("Peek");
System.Console.WriteLine($"Stack1: {stack1.Peek()}");
System.Console.WriteLine($"Stack2: {stack2.Peek()}");

System.Console.WriteLine("Count");
System.Console.WriteLine($"Stack1: {stack1.Count}");
System.Console.WriteLine($"Stack2: {stack2.Count}");

System.Console.WriteLine("Pop");
System.Console.WriteLine($"Stack1: {stack1.Pop()} has been removed.");
System.Console.WriteLine($"Stack2: {stack2.Pop()} has been removed");


System.Console.WriteLine($"PostFix result: {PostFixExample.Run("231*+9-")}");
