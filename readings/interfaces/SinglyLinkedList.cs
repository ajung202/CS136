#nullable disable

public class SinglyLinkedList<E> : IList<E>
{
    // TODO: define an instance variable to store
    //       a reference to the start of the list.
    private ListNode<E> start;
    /**
     * Creates an instance of an empty singly-linked list.
     */
    public SinglyLinkedList()
    {
        start=null;
    }

    public int Size()
    {
        int n = 0;
        for (ListNode<E> a = start; a != null; a = a.tail)
        {
            n++;
        }
        return n;
    }

    public void Insert(int i, E value)
        {
            ListNode<E> ayo = start;
            ListNode<E> added = new ListNode<E> (value);
            if (i < 0 || i > Size())
            {
                throw new ListIndexOutOfBounds();
            }
            if (i == Size())
            {
                Append(value);
                return;
            }
            if (i == 0)
            {
                Prepend(value);
                return;
            }
            int j = 0;
            for (ListNode<E> a = start; a != null; a = a.tail)
            {
                if (j == i - 1)
                {
                    ayo = a.tail;
                    a.tail = added;
                    added.tail = ayo;
                }
                j+=1;
            }
        }

    public void Prepend(E value)
    {
        ListNode<E> node = new ListNode<E>(value);
        node.tail = start;
        start = node;
    }

    public void Append(E value)
    {
        ListNode<E> node = new ListNode<E>(value);
        if (start == null)
        {
            start = node;
            return;
        }
        ListNode<E> a = start;
        while (a.tail != null)
        {
            a = a.tail;
        }
        a.tail = node;
    }

    public void Clear()
    {
        start = null;
    }

    public E Head()
    {
        return start.value;
    }

    public E Last()
    {
        ListNode<E> a = start;
        while (a.tail != null)
        {
            a = a.tail;
        }
        return a.value;
    }

    public int IndexOf(E value)
    {
        int i = 0;
        for (ListNode<E> a = start; a != null; a = a.tail)
        {
            if (object.Equals(a.value, value))
            {
                return i;
            }
            i++;
        }
        throw new ListDoesNotContainValue();
    }

    public bool Contains(E value)
    {
      for (ListNode<E> a = start; a!= null; a = a.tail)
      {
        if (object.Equals(a.value, value))
        {
          return true;
        }
      }
      return false;
    }

    public bool IsEmpty()
    {
      return (start == null);
    }

    public E Get(int i)
    {
      ListNode<E> currentValue = start;
      if (i < 0 || i > Size() - 1){
        throw new ListIndexOutOfBounds();
      }
      for (int j = 0; j < i; j++){
        currentValue = currentValue.tail;
      }
      return currentValue.value;
    }

    public E Set(int i, E value)
    {
      if (i < 0 || i > Size() - 1){
        throw new ListIndexOutOfBounds();
      }
      ListNode<E> currentNode = start;
      for (int j = 0; j < i; j++){
        currentNode = currentNode.tail;
      }
      E toReturn = currentNode.value;
      currentNode.value = value;
      return toReturn;
    }

    public E RemoveAt(int i)
    {
      E toReturn = Get(i);
      if (i < 0 || i > Size()-1){
        throw new ListIndexOutOfBounds();
      }
      if (i == 0){
        return RemoveFirst();
      }
      if (i == Size() - 1){
        return RemoveLast();
      }
      int j = 0;
      for (ListNode<E> a = start; a != null; a = a.tail){
        if (j == i-1){
          a.tail = a.tail.tail;
        }
        j += 1;
      }
      return toReturn;
    }

    public E RemoveFirst()
    {
      E removed = start.value;
      start = start.tail;
      return removed;
    }

    public E RemoveLast()
    {
      E toReturn = Last();
      int i = 0;
      for (ListNode<E> a = start; a != null; a = a.tail){
        if (i == Size() - 2){
          a.tail = null;
        }
        i++;
      }
      return toReturn;
    }

    public E Remove(E value)
    {
      return RemoveAt(IndexOf(value));
    }
}
