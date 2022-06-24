using System.Collections;

public class SinglyLinkedList<T> : IEnumerable<T>
{
    public SinglyLinkedListNode<T> Head { get; set; }
    private bool isHeadNull => Head == null;

    public void AddFirst(T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        newNode.Next = Head;
        Head = newNode;
    }

    public void AddLast(T value)
    {
        var newNode = new SinglyLinkedListNode<T>(value);
        if (isHeadNull)
        {
            Head = newNode;
            return;
        }

        var current = Head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public void AddAfter(SinglyLinkedListNode<T> refNode, T value)
    {
        if (refNode == null)
        {
            throw new ArgumentNullException();
        }

        if (isHeadNull)
        {
            AddFirst(value);
            return;
        }

        var newNode = new SinglyLinkedListNode<T>(value);
        var current = Head;
        while (current != null)
        {
            if (current.Equals(refNode))
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                return; //The empty return statement stops when it saw void.Interrupts the program.
            }

            current = current.Next;
        }
        throw new ArgumentException("The reference node is not in this list.");
    }


    public void AddAfter(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
    {
        if (refNode == null)
        {
            throw new ArgumentNullException();
        }

        if (isHeadNull)
        {
            AddFirst(newNode.Value);
            return;
        }

        var current = Head;
        while (current != null)
        {
            if (current.Equals(refNode))
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                return;

            }
            current = current.Next;
        }
        throw new ArgumentException("The reference node is not in this list.");
    }


    public void AddBefore(SinglyLinkedListNode<T> refNode, T value)
    {
        if (refNode == null)
        {
            throw new ArgumentNullException();
        }

        var newNode = new SinglyLinkedListNode<T>(value);
        var current = Head.Next;
        var prev = Head;
        if (isHeadNull || prev == refNode)
        {
            AddFirst(value);
            return;
        }

        while (current != null)
        {
            if (current.Equals(refNode))
            {
                newNode.Next = current;
                prev.Next = newNode;
                return;
            }
            current = current.Next;
            prev = prev.Next;
        }
        throw new ArgumentException("The reference node is not in this list.");
    }


    public void AddBefore(SinglyLinkedListNode<T> refNode, SinglyLinkedListNode<T> newNode)
    {
        if (refNode == null)
        {
            throw new ArgumentNullException();
        }

        var current = Head.Next;
        var prev = Head;
        if (isHeadNull || refNode == Head)
        {
            AddFirst(newNode.Value);
            return;
        }
        while (current != null)
        {
            if (current.Equals(refNode))
            {
                newNode.Next = current;
                prev.Next = newNode;
                return;
            }
            current = current.Next;
            prev = prev.Next;
        }
        throw new ArgumentException("The reference node is not in this list.");
    }

    public void Print()
    {
        var current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new SinglyLinkedListEnumerator<T>(Head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}