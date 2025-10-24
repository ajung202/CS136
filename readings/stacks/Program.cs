public class Program{
  public static void Main(string[] args){
    StackList<int> stack = new StackList<int>();
    stack.Push(1);
    stack.Push(0);
    Console.WriteLine(stack.Peek);
    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Peek);
    Console.WriteLine(stack.Pop());
    stack.Push(10);
    stack.Push(9);
    Console.WriteLine(stack.Size());
    stack.Clear();
    Console.WriteLine(stack.Size());
    //Console.WriteLine(stack.Pop());
    //stack.Clear();
    //stack.Pop();
  }
}
