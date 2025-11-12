public class Program
{
  public static void Main(string[] args)
  {

  }

  //Swaps left and right elements in an array. In-place.
  public static void Swap<E>(E[] data, int left, int right)
  {
    E temp = data[left];
    data[left] = data[right];
    data[right] = temp;
  }

  public static int Partition<E>(E[] data, IComparer<E> c, int left, int right)
  {
    E pivot = data[left];
    while (true)
    {
      while (c.Compare(data[left], pivot) < 0)
      {
        left++;
      }
      while (c.Compare(data[right], pivot) > 0)
      {
        right--;
      }
      if (left >= right)
      {
        return right;
      }
      Swap(data,left,right);
    }
  }
}
