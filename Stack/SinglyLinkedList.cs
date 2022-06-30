using System.Collections;

public class SinglyLinkedList<T> : IEnumerable<T>
{
    public SinglyLinkedListNode<T> Head { get; set; }
    private bool isHeadNull => Head == null;
    public SinglyLinkedList()
    {

    }
    public SinglyLinkedList(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            this.AddLast(item);
        }
    }

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

    public T RemoveFirst()
    {
        if (isHeadNull)
        {
            throw new Exception("Nothing to remove");
        }

        var firsValue = Head.Value;
        Head = Head.Next;
        return firsValue;
    }

    public T RemoveLast()
    {
        if (isHeadNull)
        {
            throw new Exception("Nothing to remove");
        }

        var current = Head;
        SinglyLinkedListNode<T> prev = null;
        while (current.Next != null)
        {
            prev = current;
            current = current.Next;
        }
        var lastValue = current.Value;
        prev.Next = null;
        return lastValue;
    }

    public void Remove(T value)
    {
        if (isHeadNull)
        {
            throw new Exception("Nothing to remove.");
        }
        if (value == null)
        {
            throw new ArgumentNullException("There is no value to delete");
        }

        var current = Head;
        SinglyLinkedListNode<T> prev = null;
        do
        {
            if (current.Value.Equals(value))
            {   
                // Last element?
                if (current.Next == null)
                {   
                    RemoveLast();
                    return;
                }
                if (prev == null)
                {
                    RemoveFirst();
                    return;
                }
                prev.Next = current.Next;
            }
            prev = current;
            current = current.Next;
        } while (current != null);

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
