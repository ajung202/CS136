public class Program{
  public static void Main(string[] args){
    SinglyLinkedList<int> SLL = new SinglyLinkedList<int>();
    SLL.Prepend(1);
    SLL.Prepend(2);
    SLL.Prepend(3);
    for (int i = 0; i < SLL.Size(); i++){
      Console.WriteLine(SLL.Get(i));
    }
  }
}
