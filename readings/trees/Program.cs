public class Program
{
  public static void Main(string[] args)
  {
    var root = new BinaryTreeNode<string>("a");
    root.left = new BinaryTreeNode<string>("b");
    root.right = new BinaryTreeNode<string>("c");
    root.right.left = new BinaryTreeNode<string>("d");
    root.right.left.left = new BinaryTreeNode<string>("e");
    root.right.left.right = new BinaryTreeNode<string>("f");
    root.right.left.left.left = new BinaryTreeNode<string>("g");

    Console.WriteLine(root);

    var sequence = new Vector<string>();

    root.InOrderTraversal(sequence);
    Console.WriteLine(sequence);

    sequence.Clear();

    root.PreOrderTraversal(sequence);
    Console.WriteLine(sequence);

    sequence.Clear();

    root.PostOrderTraversal(sequence);
    Console.WriteLine(sequence);
  }
}
