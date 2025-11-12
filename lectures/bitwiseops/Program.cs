public class Program
{
  public static void Main(string[] args)
  {
    for (int k = 0; k < 10; k++)
    {
      ToBinary(k);
      Console.WriteLine('\n');
    }
  }

  //Takes decimal integer n and prints its binary representation
  public static void ToBinary(int n)
  {
    for (int i = 31; i >= 0; i--)
    {
      if(((1 << i) & n) == (1 << i))
      {
        Console.Write('1');
      }
      else
      {
        Console.Write('0');
      }
    }
  }
}
