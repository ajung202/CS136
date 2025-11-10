public class BinaryTreeNode<T>
{
  public T value;
  public BinaryTreeNode<T> left;
  public BinaryTreeNode<T> right;

  public BinaryTreeNode(T value)
  {
    this.value = value;
    left = null;
    right = null;
  }

  public override string ToString()
  {
    //We want (value left right)
    //We want value only when there are no subtrees. So....
    if (left == null && right == null)
    {
      return $"{value}";
    }
    else
    {
      return $"({value} {left} {right})";
    }
  }

  public void InOrderTraversal(Vector<T> sequence)
  {
    //left, root, right

    //left
    if (left != null)
    {
      left.InOrderTraversal(sequence);
    }

    //root
    sequence.Append(value);

    //right
    if (right != null)
    {
      right.InOrderTraversal(sequence);
    }
  }

  public void PreOrderTraversal(Vector<T> sequence)
  {
    //root, left, right

    //root
    sequence.Append(value);

    //left
    if (left != null)
    {
      left.PreOrderTraversal(sequence);
    }

    //right
    if (right != null)
    {
      right.PreOrderTraversal(sequence);
    }
  }

  public void PostOrderTraversal(Vector<T> sequence)
  {
    //left, right, root

    //left
    if (left != null)
    {
      left.PostOrderTraversal(sequence);
    }

    //right
    if (right != null)
    {
      right.PostOrderTraversal(sequence);
    }

    //root
    sequence.Append(value);

  }


}
