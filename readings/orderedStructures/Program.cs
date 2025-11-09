public class Program
{
  public static void Main(string[] args)
  {
    Random r = new Random();
    OrderedVector<int> v = new OrderedVector<int>(new IntComparator());
    for (int i = 0; i < 100; i++)
    {
      v.Insert(r.Next(0,100));
    }
    Console.WriteLine(v);
  }
}
