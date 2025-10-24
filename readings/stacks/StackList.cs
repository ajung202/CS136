public class StackList <E> : IStack <E> {

  protected SinglyLinkedList<E> stack;
  protected int count;

  public StackList(){
    stack = new SinglyLinkedList<E>();
  }

  public void Clear(){
    stack.Clear();
    count = 0;
  }

  /**
   * Determine if stack is empty.
   *
   * @return True if stack has no elements.
   */
  public bool IsEmpty {
     get {return count == 0;}
  }

  /**
   * Return the element at the top of the stack
   * without altering the stack.
   * Throws `ListDoesNotContainValue` if the stack is empty.
   *
   * @return The topmost element.
   */
  public E Peek {
    get {
      if (count == 0){
        throw new ListDoesNotContainValue();
      }
      return stack.Head();
    }
  }

  /**
   * Remove and return the element at the top of the
   * stack.
   * Throws `ListDoesNotContainValue` if the stack is empty.
   *
   * @return The topmost element.
   */
  public E Pop(){
    if (count == 0){
      throw new ListDoesNotContainValue();
    }
    count -= 1;
    return stack.RemoveFirst();
  }

  /**
   * Place the given value on the top of the stack.
   */
  public void Push(E value){
    count += 1;
    stack.Prepend(value);
  }

  /**
   * Compute the size of the stack.
   *
   * @return the size of the stack.
   */
  public int Size(){
    return count;
  }
}
