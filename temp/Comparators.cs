public class FirstStudentComparator : IComparer<Student>{
  public int Compare(Student student1, Student student2){
    string name1 = student1.name;
    string name2 = student2.name;
    return name1.CompareTo(name2);
  }
}
