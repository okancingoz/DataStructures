public class DoublyLinkedListNode<T> {
    public T Value { get; set; }

    public DoublyLinkedListNode<T> Prev { get; set; }
    public DoublyLinkedListNode<T> Next { get; set; }

    public DoublyLinkedListNode(T value)
    {
        this.Value = value;
    }

    public override string ToString() => Value.ToString();
}