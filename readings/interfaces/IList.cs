//Interface describing list abstract data type. A list is a sequence of data with a head. A value may be added or removed from eithe end as well as by-value from the middle

public interface IList<E>{

  //Returns size of list
  public int Size();

  //Inserts value E at index i of list
  public void Insert(int i, E value);

  //Adds value to head of list
  public void Prepend(E value);

  //Adds value to the end of list
  public void Append(E value);

  //Remove all elements of list
  public void Clear();

  //Returns reference to first element of list
  public E Head();

  //Returns reference to last element of list
  public E Last();

  //Determines first location of a value in list.
  public int IndexOf(E value);

  //Returns true if list contains; returns false if list does not contain
  public bool Contains(E value);

  //Determines if list is IsEmpty
  public bool IsEmpty();

  //Gets pointer to element at index i
  public E Get(int i);

  //Set value located at index i to object o and returns old value
  public E Set(int i, E value);

  //Removes and returns value at location i
  public E RemoveAt(int i);

  //Removes and returns value at location 0
  public E RemoveFirst();

  //Removes last value from list
  public E RemoveLast();

  //Removes a value from list. At most one of value will be removed
  public E Remove(E value);

}


//We have custom exceptions we have built out to use during implementations of IList

public class ListDoesNotContainValue : Exception
{
    public ListDoesNotContainValue() : base() { }
}

public class ListIndexOutOfBounds : Exception
{
    public ListIndexOutOfBounds() : base() { }
}
