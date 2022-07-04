var numbers = new int[] {10,20,30};
var q1 = new Queue<int>();
var q2 = new Queue<int>(QueueType.LinkedList);

foreach (var item in numbers)
{
    System.Console.WriteLine(item);
    q1.EnQueue(item);
    q2.EnQueue(item);
}

System.Console.WriteLine($"q1 count : {q1.Count}");
System.Console.WriteLine($"q2 count : {q2.Count}");

System.Console.WriteLine($"{q1.DeQueue()} has been to be removed from q1");
System.Console.WriteLine($"{q2.DeQueue()} has been removed from q2");

System.Console.WriteLine($"q1 count : {q1.Count}");
System.Console.WriteLine($"q2 count : {q2.Count}");

System.Console.WriteLine($"q1 peek: {q1.Peek()}");
System.Console.WriteLine($"q2 peek: {q2.Peek()}");