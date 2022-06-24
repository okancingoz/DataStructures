var linkedList = new SinglyLinkedList<int>();
linkedList.AddFirst(1);
linkedList.AddFirst(2);
linkedList.AddFirst(3);
// 3 2 1 O(1)

linkedList.AddLast(5);
linkedList.AddLast(9);
// 3 2 1 5 9 O(n)

linkedList.AddAfter(linkedList.Head.Next,32);
// 3 2 32 1 5 9 O(n)
linkedList.AddAfter(linkedList.Head.Next.Next.Next,45);
// 3 2 32 1 45 5 9 O(n)

var newNode = new SinglyLinkedListNode<int>(12);
linkedList.AddAfter(linkedList.Head,newNode);
// 3 12 2 32 1 45 5 9
linkedList.AddBefore(linkedList.Head.Next,86);
linkedList.AddBefore(linkedList.Head,11);

var newNode2 = new SinglyLinkedListNode<int>(23);
linkedList.AddBefore(linkedList.Head.Next.Next,newNode2);
linkedList.Print();

// var list = new LinkedList<int>();
// list.AddFirst(1);
// list.AddFirst(2);
// list.AddFirst(3);

// foreach (var item in list)
// {
//     Console.WriteLine(item);
// }

foreach (var item in linkedList)
{
    Console.WriteLine(item);
}