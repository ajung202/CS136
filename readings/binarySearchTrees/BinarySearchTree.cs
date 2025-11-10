#nullable disable

public class BinarySearchTree<T>
{
  protected BinaryTreeNode<T> root;
  protected IComparer<T> c;

  public BinarySearchTree(IComparer<T> c)
  {
    root = null;
    this.c = c;
  }

  //inserts a value into a tree maintaing the order provided by c
  public void Insert(T value)
  {
    //base case: empty tree
    if (root == null)
    {
      root = new BinaryTreeNode<T>(value);
    }

    //recursive case
    else
    {
      InsertHelper(root, value);
    }
  }

  //recursive implementation of insert
  protected void InsertHelper(BinaryTreeNode<T> cur, T value)
  {
    //key goes to the left if less than
    if (c.Compare(value, cur.value) < 0)
    {
      //if there is nothing to the left, insert here
      if (cur.left == null)
      {
        cur.left = new BinaryTreeNode<T>(value);
      }
      //otherwise recurse left
      else
      {
        InsertHelper(cur.left, value);
      }
    }

    //key goes to the right if greater than or equal to
    else
    {
      //if there is nothing to the right, insert here
      if (cur.right == null)
      {
        cur.right = new BinaryTreeNode<T>(value);
      }
      //if there is something to the right, recurse right
      else
      {
        InsertHelper(cur.right, value);
      }
    }
  }

  public T Locate(T value)
  {
    return LocateHelper(root, value);
  }

  protected T LocateHelper(BinaryTreeNode<T> cur, T value)
  {
    if (cur == null)
    {
      throw new TreeDoesNotContainValue();
    }
    else
    {
      int cmp = c.Compare(value, cur.value);
      if (cmp == 0)
      {
        return cur.value;
      }
      else if (cmp < 0)
      {
        return LocateHelper(cur.left, value);
      }
      else
      {
        return LocateHelper(cur.right, value);
      }
    }
  }

  /*
  public int Size()
  {
    return root.Size();
  }
  */

  public void Clear()
  {
    root = null;
  }

  public override string ToString()
  {
    var sequence = new Vector<T>();
    root.InOrderTraversal(sequence);
    return $"{sequence}";
  }

  public void InOrderTraversal(Vector<T> sequence)
  {
    if (root != null)
    {
      root.InOrderTraversal(sequence);
    }
  }
}

public class TreeDoesNotContainValue : Exception
{
  public TreeDoesNotContainValue() : base() {}
}
