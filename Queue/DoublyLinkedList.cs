using System.Collections;

public class DoublyLinkedList<T> : IEnumerable
{
    public DoublyLinkedListNode<T> Head { get; set; }
    public DoublyLinkedListNode<T> Tail { get; set; }
    private bool isHeadNull => Head == null;
    public DoublyLinkedList()
    {
        
    }

    public DoublyLinkedList(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            AddLast(item);
        }
    }
    public void AddFirst(T value)
    {
        var newNode = new DoublyLinkedListNode<T>(value);
        if (value == null)
        {
            throw new Exception("Value is not be empty");
        }
        if (Head != null)
        {
            Head.Prev = newNode;
        }
        newNode.Next = Head;
        newNode.Prev = null;
        Head = newNode;

        if (Tail == null)
        {
            Tail = Head;
        }
    }

    public void AddLast(T value)
    {   
        if (Tail == null)
        {
            AddFirst(value);
            return;
        }
        var newNode = new DoublyLinkedListNode<T>(value);
        Tail.Next = newNode;
        newNode.Next = null;
        newNode.Prev = Tail;
        Tail = newNode;
        return;
    }

    public void AddAfter(DoublyLinkedListNode<T> refNode,DoublyLinkedListNode<T> newNode) 
    {   
        
        if (refNode == null)
        {
            throw new ArgumentNullException();
        }

        if (refNode == Head && refNode == Tail)
        {
            refNode.Next = newNode;
            refNode.Prev = null;
            newNode.Prev = refNode;
            newNode.Next = null;
            Head = refNode;
            Tail = newNode;
            return;
        }

        if (refNode != Tail)
        {
            newNode.Prev = refNode;
            newNode.Next = refNode.Next;
            refNode.Next.Prev = newNode;
            refNode.Next = newNode;
        }
        else
        {
            newNode.Prev = refNode;
            newNode.Next = null;
            refNode.Next = newNode;
            Tail = newNode;
        }

    }

    public void AddBefore(DoublyLinkedListNode<T> refNode,DoublyLinkedListNode<T> newNode)
    {
        if (refNode == null)
        {
            throw new ArgumentNullException();
        }
        if (refNode == Head)
        {
            newNode.Next = refNode;
            refNode.Prev = newNode;
            Head = newNode;
            return;
        }
        if (refNode != Tail)
        {
            newNode.Next = refNode;
            newNode.Prev = refNode.Prev;
            refNode.Prev.Next = newNode;
            refNode.Prev = newNode;
        }
    }

    public T RemoveFirst()
    {   
        if (isHeadNull)
        {
            throw new Exception("There is no element in this array.");
        }
        var current = Head;
        Head = Head.Next;
        Head.Prev = null;
        return current.Value;
    }

    public T RemoveLast()
    {
        if (isHeadNull)
        {
            throw new Exception("There is no element is this array");
        }
        var current = Tail;
        Tail.Prev.Next = null;
        Tail = Tail.Prev;
        return current.Value;
    }


    // It can also take value (T) as parameter (overloading)
    public T Remove(DoublyLinkedListNode<T> refNode)
    {
        if (isHeadNull)
        {
            throw new Exception ("There is no element in this array");
        }
        if (refNode == Head)
        {
            RemoveFirst();
            return refNode.Value;
        }
        if (refNode == Tail)
        {
            RemoveLast();
            return refNode.Value;
        }
        var current = Head;
        while (current != null)
        {
            if (current.Value.Equals(refNode.Value))
            {
                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
                return current.Value;
            }
            current = current.Next;
        }
        return refNode.Value;
    }

    private List<DoublyLinkedListNode<T>> GetAllNodes()
    {
        var list = new List<DoublyLinkedListNode<T>>();
        var current = Head;
        while(current != null)
        {
            list.Add(current);
            current = current.Next;
        }
        return list;
    }
    public void Print()
    {
        var current = Head;
        while (current != null)
        {
            System.Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return GetAllNodes().GetEnumerator();
    }
}

   