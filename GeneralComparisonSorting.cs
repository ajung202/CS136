public class Program{
  public static void Main(string[] args){
      Student[] testArr = new Student[2];
      Student student1 = new Student(1234,"Prospect 418","Lebron");
      Student student2 = new Student(2234, "Prospect 312", "Anthony");
      testArr[0] = student1;
      testArr[1] = student2;
      Console.WriteLine(testArr[0].name);
      Console.WriteLine(testArr[1].name);
      BubbleSort(testArr, new FirstStudentComparator());
      Console.WriteLine("New Version:");
      Console.WriteLine(testArr[0].name);
      Console.WriteLine(testArr[1].name);
  }

  public static void BubbleSort(Student[] data, IComparer<Student> c){
    for (int numSorted = 0; numSorted < data.Length; numSorted++){
      for (int i = 1; i < data.Length; i++){
        //Console.WriteLine(data[i-1].name);
        //Console.WriteLine(data[i].name);
        //Console.WriteLine(c.Compare(data[i-1], data[i]));
        if (c.Compare(data[i-1], data[i]) > 0){
          //Console.WriteLine("hello");
          Swap(data, i, i-1);
        }
      }
    }
  }

  public static void Swap<E>(E[] data, int i, int j){
    E temp = data[i];
    data[i] = data[j];
    data[j] = temp;
  }
}
