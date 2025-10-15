public class StringComparator : IComparer<string> //We create a contract here that says we will be comparing string to string
  {
    public int Compare(string a, string b)
      {
        if (a.Length > b.Length)
        {
          return 1;
        }
        return -1;
      }
  }
