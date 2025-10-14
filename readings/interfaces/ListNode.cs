#nullable disable

/**
 * A class representing a single element in a singly-linked list.
 */
public class ListNode<E>
{
    public E value;          // the value of the element
    public ListNode<E> tail; // a reference to the next node

    /**
     * Constructs a node with the given value.
     *
     * @param val An element value of type E.
     */
    public ListNode(E value)
    {
        this.value = value;
    }
}
