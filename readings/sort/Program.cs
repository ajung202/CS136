public class Program{
  public static void Main(string[] args){
    string[] data = {"aaa", "aa", "a"};
    /* Bubble Sort testing
    Console.WriteLine(string.Join(" ", data));
    BubbleSort(data, new StringComparator());
    Console.WriteLine(string.Join(" ", data));
    */

    /*
    Console.WriteLine(string.Join(" ", data));
    SelectionSort(data, new StringComparator());
    Console.WriteLine(string.Join(" ", data));
    */

    //Insertion Sort test
    Console.WriteLine(string.Join(" ", data));
    InsertionSort(data, new StringComparator());
    Console.WriteLine(string.Join(" ", data));
  }


  /*
  BubbleSort finds the greatest number and bubbles it to the right. Every iteration is n-1 less things because max is already on the very right.
  We will take in the comparator IComparer<E> c as "<" operation and generic array of type E
  Best Case: O(n^2)
  Worst Case: O(n^2)
  No matter what happens, you have to iterate through O(n^2) many times
  */
  public static void BubbleSort<E> (E[] data, IComparer<E> c){
    for (int numSorted = 0; numSorted < data.Length; numSorted++){
      for (int i = 1; i < data.Length - numSorted; i++){
        if (c.Compare(data[i-1], data[i]) > 0){
          Swap(data, i, i-1);
        }
      }
    }
  }

  /*
  Selection Sort finds the max number and places it on the right
  We will take in the comparator IComparer<E> as c as "<" operation and generic array of type E
  Best Case: O(n^2)
  Worst Case: O(n^2)
  But, because we don't write to memory as often, it is good for preserving computers
  */
  public static void SelectionSort<E> (E[] data, IComparer<E> c){
    int numUnsorted = data.Length;
    while (numUnsorted > 0){
      int max = 0; //index of max value
      for (int i = 0; i < numUnsorted; i++){
        if (c.Compare(data[i], data[max]) > 0){
          max = i;
        }
      }
      Swap(data, max, numUnsorted-1);
      numUnsorted--;
    }
  }


  /*
  InsertionSort has an left/inner sorted side and a right/outer non-sorted side
  You take one element off of the non sorted side and slide it in where it fits on the sorted slide
  Best Case: O(n)
  Worst Case: O(n^2)
  */
  public static void InsertionSort<E> (E[] data, IComparer<E> c){
    int numSorted = 1;
    while (numSorted < data.Length){
      E toSort = data[numSorted]; //Next unsorted value
      int i;
      for (i = numSorted; i > 0; i--){ // Move backwards and find where to sort it
        if(c.Compare(toSort, data[i-1]) < 0){
          data[i] = data[i-1]; //if toSort < data[i-1], you slide things to the right to make room for insertion
        }
        else{
          break;
        }
      }
      data[i] = toSort; //Insert unsorted value into correct space
      numSorted++;
    }
  }

  public static void Swap<E>(E[] data, int i, int j){
    E temp = data[i];
    data[i] = data[j];
    data[j] = temp;
  }
}
