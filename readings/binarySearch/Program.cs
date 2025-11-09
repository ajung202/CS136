public class Program
{
  public static void Main(string[] args)
  {
    string[] arr = {"Alex", "Brian", "Cate", "David"};
    FirstStudentComparator c = new FirstStudentComparator();
    Console.WriteLine(ArrSearch(arr, "Cate", c));

    Vector<String> vec = new Vector<String>();
    vec.Append("Alex");
    vec.Append("Brian");
    vec.Append("Cate");
    vec.Append("David");
    Console.WriteLine(VectorSearch(vec, "Alex", c));
    Console.WriteLine(VectorSearch(vec, "Brian", c));
    Console.WriteLine(VectorSearch(vec, "Cate", c));
    Console.WriteLine(VectorSearch(vec, "David", c));
    //Console.WriteLine(VectorSearch(vec, "LeBron", c));

  }

  public static int VectorSearch<E>(Vector<E> vector, E elem, IComparer<E> c)
  {
    return VectorSearchHelper(vector, elem, c, 0, vector.Size());
  }

  private static int VectorSearchHelper<E>(Vector<E> vector, E elem, IComparer<E> c, int lo, int hi)
  {
    //Base Case #1
    if (lo > hi)
    {
      return -1;
    }

    //Calculate midpoint
    int mid = (lo + hi) / 2;

    //Comparison
    int compare = c.Compare(elem, vector.Get(mid));

    //Base Case #2
    if (compare == 0)
    {
      return mid;
    }

    else if (compare > 0)
    {
      return VectorSearchHelper(vector, elem, c, mid + 1, hi);
    }

    else
    {
      return VectorSearchHelper(vector, elem, c, lo, mid - 1);
    }
  }



  public static int ArrSearch<E>(E[] arr, E elem, IComparer<E> c)
  {
    return ArrSearchHelper(arr, elem, c, 0, arr.Length - 1);
  }

  private static int ArrSearchHelper<E>(E[] arr, E elem, IComparer<E> c, int lo, int hi)
  {
    //Base Case #1
    if (lo > hi)
    {
      return -1;
    }

    //Calculate midpoint
    int mid = (lo + hi) / 2;

    //Comparison
    int compare = c.Compare(elem, arr[mid]);

    //Base Case #2
    if (compare == 0)
    {
      return mid;
    }

    //Recursive Case #1: Need to look at left half
    else if (compare < 0)
    {
      return ArrSearchHelper(arr, elem, c, lo, mid-1);
    }
    else //Recursive Case #2: Need to look at right half
    {
      return ArrSearchHelper(arr, elem, c, mid+1, hi);
    }
  }
}
