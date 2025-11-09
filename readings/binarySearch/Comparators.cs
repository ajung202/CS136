public class FirstStudentComparator : IComparer<String>{
  public int Compare(String str1, String str2){
    return str1.CompareTo(str2);
  }
}
