public class Program
{
  public static void Main(string[] args)
  {
    string test = "hello";
    Console.WriteLine(W(test, 1));
  }

  public static string W(string toTwist, int i)
  {
    int length = toTwist.Length;
    if (length == 0 || length == 1)
    {
      return toTwist;
    }
    if (i % 2 == 1)
    {
      return(toTwist[0] + W(toTwist.Substring(1, length-2), i+1) + toTwist[length-1]);
    }
    else
    {
      return(toTwist[length - 1] + W(toTwist.Substring(1, length-2), i+1) + toTwist[0]);
    }
  }
}
