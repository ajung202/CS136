public class OrderedVector<E> : Vector<E>
{
  protected IComparer<E> c;

  public OrderedVector(IComparer<E> c) : base()
  {
    this.c = c;
  }

  public void Insert(E value)
  {
    //invariant: data is always sorted
    //use binary search to find where to insert
    int index = Search(value, c);
    base.Insert(index, value);
  }

  public int Search(E elem, IComparer<E> c)
  {
    return SearchHelper(this, elem, c, 0, Size() - 1); // why no base.Size()?
  }

  public static int SearchHelper(Vector<E> vec, E elem, IComparer<E> c, int lo, int hi)
  {
    if (lo > hi) // Base Case #1 -- not found
    {
      return lo;
    }

    int mid = (lo + hi) / 2;
    int comp = c.Compare(elem, vec.Get(mid));

    if (comp == 0)
    {
      return mid;
    }

    else if (comp > 0)
    {
      return SearchHelper(vec, elem, c, mid + 1, hi);
    }

    else
    {
      return SearchHelper(vec, elem, c, lo, mid - 1);
    }

  }

}
