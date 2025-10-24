public interface IStack<E>
{
    /**
     * Remove all elements of stack.
     */
    public void Clear();

    /**
     * Determine if stack is empty.
     *
     * @return True if stack has no elements.
     */
    public bool IsEmpty { get; }

    /**
     * Return the element at the top of the stack
     * without altering the stack.
     * Throws `ListDoesNotContainValue` if the stack is empty.
     *
     * @return The topmost element.
     */
    public E Peek { get; }

    /**
     * Remove and return the element at the top of the
     * stack.
     * Throws `ListDoesNotContainValue` if the stack is empty.
     *
     * @return The topmost element.
     */
    public E Pop();

    /**
     * Place the given value on the top of the stack.
     */
    public void Push(E value);

    /**
     * Compute the size of the stack.
     *
     * @return the size of the stack.
     */
    public int Size();
}
