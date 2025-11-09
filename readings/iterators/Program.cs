public class Program
{
  public static void Main(string[] args)
  {
    SinglyLinkedList<String> testSLL = new SinglyLinkedList<String>();
    testSLL.Prepend("hello");
    testSLL.Prepend("LeBron");
    testSLL.Prepend("James");
    foreach (String s in testSLL)
    {
      Console.WriteLine(s);
    }
  }
}
