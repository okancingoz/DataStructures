var linkedList = new DoublyLinkedList<int>();
linkedList.AddFirst(4);
linkedList.AddFirst(12);
linkedList.AddLast(15);
linkedList.AddLast(34);
var newNode = new DoublyLinkedListNode<int>(80); 
linkedList.AddBefore(linkedList.Head,new DoublyLinkedListNode<int>(80));
linkedList.AddAfter(linkedList.Head.Next,newNode);
//linkedList.Print();
linkedList.RemoveFirst();
linkedList.RemoveFirst();
System.Console.WriteLine(linkedList.RemoveLast());


foreach (var item in linkedList)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("---------------");

var list = new DoublyLinkedList<char>(new List<char>() {'a','b','c','d'});
list.Remove(list.Head.Next.Next.Next);
foreach (var item in list)
{
    System.Console.WriteLine(item);
}