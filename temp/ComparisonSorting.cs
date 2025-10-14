/*
public class Program{
  public static void Main(string[] args){
      int[] data = {3,4,5,1};
      Console.WriteLine(string.Join(" ", data));
      BubbleSort(data);
      Console.WriteLine(string.Join(" ", data));
  }

  //Suppose data = [3,4,5,1]
  //Move left to right and bubble up the greatest number to the right
  public static void BubbleSort(int[] data){
    for (int numSorted = 0; numSorted < data.Length; numSorted++){
      for (int i = 1; i < data.Length; i++){
        if (data[i-1] > data[i]){
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
*/
