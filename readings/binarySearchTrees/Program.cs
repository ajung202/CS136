public class Program
{
  public static void Main(string[] args)
  {
    int[] data = {-91, -70, 74, -18, 10, 86, 75, -49, -44, 73};
    Console.WriteLine("Input: " + String.Join(", ", data));

    //initialize an empty BST with an int comparator
    IComparer<int> c = new IntComparator();
    var bst = new BinarySearchTree<int>(c);

    //fill it with data
    for (int i = 0; i < data.Length; i++)
    {
      bst.Insert(data[i]);
    }

    //Print the in-order traversal
    Console.WriteLine(bst);

    //Look for -18, which is in the tree
    Console.WriteLine(bst.Locate(-18));

    //Look for 1, which is not (it will throw an exception)
    Console.WriteLine(bst.Locate(1));


  }
}
